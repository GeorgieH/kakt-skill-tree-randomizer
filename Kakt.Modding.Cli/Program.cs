using DryIoc;
using DryIoc.Messages;
using Kakt.Modding.Cli;
using Kakt.Modding.Cli.KnightsTale;
using Kakt.Modding.Core;
using Kakt.Modding.Core.KnightsTale.Heroes;
using Kakt.Modding.Core.KnightsTale.Randomization;

static void Exit(string message)
{
    Console.WriteLine(message);
    Console.WriteLine("Press any key to exit...");
    Console.ReadKey();
    Environment.Exit(0);
}

try
{
    var container = new Container();
    Bootstrapper.Run(container);
    var handler = container.Resolve<IMessageHandler<GenerateRandomSkillTreeConfigurationMessage, IEnumerable<Hero>>>();
    var heroes = await handler.Handle(new GenerateRandomSkillTreeConfigurationMessage(), CancellationToken.None);

    var fileSystemService = container.Resolve<IFileSystemService>();
    var outputPath = fileSystemService.OutputDirectory;

    if (fileSystemService.DirectoryExists(outputPath))
    {
        fileSystemService.DeleteDirectory(outputPath);
    }

    var documentRepository = container.Resolve<IDocumentRepository>();

    fileSystemService.WriteDocument(
        fileSystemService.SkillTreeOutputDirectory,
        FileNames.SkillTree,
        documentRepository.GetSkillTreeDocument().ToString());

    foreach (var hero in heroes)
    {
        if (hero is SirMordred)
        {
            continue;
        }

        fileSystemService.WriteDocument(
            fileSystemService.HeroesOutputDirectory,
            fileSystemService.GetHeroConfigurationFileName(hero),
            documentRepository.GetHeroDocument(hero).ToString());
    }

    fileSystemService.WriteDocument(
        fileSystemService.HeroesOutputDirectory,
        FileNames.MerlinHermit,
        documentRepository.GetHermitDocument().ToString());

    Exit("Done!");
}
catch (Exception ex)
{
    var directory = AppDomain.CurrentDomain.BaseDirectory;
    var path = Path.Combine(directory, $"debug_log_{DateTime.Now:yyyyMMddHHmmss}.txt");
    File.WriteAllText(path, ex.ToString());
    Exit($"ERROR: An unexpected error occurred. Debug log has been created at {path}");
}