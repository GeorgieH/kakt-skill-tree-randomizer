using Kakt.Modding.Application;
using Kakt.Modding.Application.Heroes;
using Kakt.Modding.Application.Randomization;
using Kakt.Modding.Application.Skills;
using Kakt.Modding.Cli;
using Kakt.Modding.Configuration;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Text;
using System.Text.Json;

static void Exit(string message)
{
    Console.WriteLine(message);
    Console.WriteLine("Press any key to exit...");
    Console.ReadKey();
    Environment.Exit(0);
}

static string GetFileNotFoundMessage(string path)
{
    return $"File not found: {path}";
}

static string GetRandomizationConfiguration()
{
    var path = Path.Combine(FileSystemHelpers.GetLocalPath(), "randomization_config.json");

    if (!File.Exists(path))
    {
        Exit(GetFileNotFoundMessage(path));
    }

    return File.ReadAllText(path, Encoding.UTF8);
}

static void WriteDocument(string outputPath, string fileName, CfgDocument document)
{
    Directory.CreateDirectory(outputPath);
    FileSystemHelpers.WriteFile(Path.Combine(outputPath, fileName), document.ToString());
}

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddSingleton<IHeroRepository, HeroRepository>();
builder.Services.AddSingleton<ISkillRepository, SkillRepository>();
builder.Services.AddSingleton<ISkillUpgradeRepository, SkillUpgradeRepository>();
builder.Services.AddSingleton<IRandomNumberGeneratorService, RandomNumberGeneratorService>();
builder.Services.AddSingleton<IDocumentRepository, DocumentRepository>();
builder.Services.AddSingleton<ILogger, ConsoleLogger>();

builder.Services.AddMediatR(config =>
    config.RegisterServicesFromAssembly(typeof(GetRandomSkillTreeConfigurationCommand).Assembly));

using var host = builder.Build();

var mediator = host.Services.GetRequiredService<IMediator>();

var randomizationConfig = GetRandomizationConfiguration();
var config = JsonSerializer.Deserialize<RandomizationConfiguration>(randomizationConfig)!;

var heroRepository = host.Services.GetRequiredService<IHeroRepository>();
var heroes = heroRepository.GetAll();

foreach (var hero in heroes)
{
    await mediator.Send(new GetRandomSkillTreeConfigurationCommand(hero, config.Profiles.Default));
}

var outputPath = FileSystemHelpers.GetOutputPath();

if (Directory.Exists(outputPath))
{
    Directory.Delete(outputPath, true);
}

var documentRepository = host.Services.GetRequiredService<IDocumentRepository>();

WriteDocument(Path.Combine(outputPath, "Cfg", "Config"), FileNames.SkillTree, documentRepository.GetSkillTreeDocument());

var heroesOutputPath = Path.Combine(outputPath, "Cfg", "Actors", "Heroes");

foreach (var hero in heroes)
{
    WriteDocument(heroesOutputPath, FileSystemHelpers.GetHeroConfigurationFileName(hero), documentRepository.GetHeroDocument(hero));
}

WriteDocument(heroesOutputPath, FileNames.MerlinHermit, documentRepository.GetHermitDocument());

Exit("Done!");
