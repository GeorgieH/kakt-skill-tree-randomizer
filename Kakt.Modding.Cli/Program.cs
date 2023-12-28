using Kakt.Modding.Cli;
using Kakt.Modding.Configuration;
using Kakt.Modding.Configuration.SkillTree;
using Kakt.Modding.Core.Heroes;
using Kakt.Modding.Core.Skills;
using Kakt.Modding.Randomization.Skills.Default;
using System.Reflection.Metadata;
using System.Text;

static void Exit(string message)
{
    Console.WriteLine(message);
    Console.WriteLine("Press any key to exit...");
    Console.ReadKey();
}

static string GetFileNotFoundMessage(string path)
{
    return $"File not found: {path}";
}

static string GetLocalPath()
{
    return AppDomain.CurrentDomain.BaseDirectory;
}

static string GetOutputPath()
{
    return Path.Combine(GetLocalPath(), "King Arthur Knight's Tale");
}

static string GetSkillTreePath()
{
    return Path.Combine(GetLocalPath(), FileNames.SkillTree);
}

static string GetHeroConfigurationFileName(Hero hero)
{
    return hero switch
    {
        BlackKnight => FileNames.BlackKnight,
        FaerieKnight => FileNames.FaerieKnight,
        LadyBoudicea => FileNames.LadyBoudicea,
        LadyDindraine => FileNames.LadyDindraine,
        LadyGuinevere => FileNames.LadyGuinevere,
        LadyIsolde => FileNames.LadyIsolde,
        LadyMorganaLeFay => FileNames.LadyMorganaLeFay,
        LadyMorgawse => FileNames.LadyMorgawse,
        Merlin => FileNames.Merlin,
        RedKnight => FileNames.RedKnight,
        SirBalan => FileNames.SirBalan,
        SirBalin => FileNames.SirBalin,
        SirBedievere => FileNames.SirBedievere,
        SirBors => FileNames.SirBors,
        SirBrunorLeNoir => FileNames.SirBrunorLeNoir,
        SirDagonet => FileNames.SirDagonet,
        SirDamas => FileNames.SirDamas,
        SirEctor => FileNames.SirEctor,
        SirGalahad => FileNames.SirGalahad,
        SirKay => FileNames.SirKay,
        SirLancelot => FileNames.SirLancelot,
        SirLanval => FileNames.SirLanval,
        SirLeodegrance => FileNames.SirLeodegrance,
        SirLucan => FileNames.SirLucan,
        SirMordred => FileNames.SirMordred,
        SirPelleas => FileNames.SirPelleas,
        SirPercival => FileNames.SirPercival,
        SirTegyr => FileNames.SirTegyr,
        SirTristan => FileNames.SirTristan,
        SirYvain => FileNames.SirYvain,
        WhiteKnight => FileNames.WhiteKnight,
        _ => throw new NotImplementedException(),
    };
}

static string GetHeroConfigurationFilePath(Hero hero)
{
    return Path.Combine(GetLocalPath(), GetHeroConfigurationFileName(hero));
}

static void WriteFile(string path, string content)
{
    File.WriteAllText(path, content, Encoding.UTF8);
}

static void CheckSkillTreeExists()
{
    var skillTreePath = GetSkillTreePath();

    if (!File.Exists(skillTreePath))
    {
        Exit(GetFileNotFoundMessage(skillTreePath));
    }
}

static void WriteSkillTree(string outputPath, IEnumerable<Hero> heroes)
{
    var skillTreePath = GetSkillTreePath();
    var document = CfgDocument.Parse(skillTreePath);
    SkillTreeWriter.Overwrite(document, heroes);

    var configPath = Path.Combine(outputPath, "Cfg", "Config");
    Directory.CreateDirectory(configPath);
    WriteFile(Path.Combine(configPath, FileNames.SkillTree), document.ToString());
}

static bool CheckHeroConfigurationExists(Hero hero, out string configPath)
{
    configPath = GetHeroConfigurationFilePath(hero);
    return File.Exists(configPath);
}

static void CheckHeroConfigurationsExist(IEnumerable<Hero> heroes)
{
    var exit = false;

    foreach (var hero in heroes)
    {
        var result = CheckHeroConfigurationExists(hero, out var path);

        if (!result)
        {
            Console.WriteLine(GetFileNotFoundMessage(path));
            exit = true;
        }
    }

    if (exit)
    {
        Exit("ERROR: One or more hero .cfg files not found");
    }
}

static void WriteHeroConfigurations(string outputPath, IEnumerable<Hero> heroes)
{
    var heroesPath = Path.Combine(outputPath, "Cfg", "Actors", "Heroes");
    Directory.CreateDirectory(heroesPath);

    foreach (var hero in heroes)
    {
        var configPath = GetHeroConfigurationFilePath(hero);
        var document = CfgDocument.Parse(configPath);

        foreach (var preset in hero.Presets)
        {
            var starterSkills = preset.LearnedSkills
                .Where(s => s is Skill skill && skill.Starter);

            var learnedSkills = preset.LearnedSkills
                .Except(starterSkills)
                .Select(s => s.ConfigurationName);

            var value = string.Join(",", learnedSkills);
            var property = (CfgProperty)document["Hero"]!["Presets"]![preset.Name]!;
            property.Value = value;
        }

        WriteFile(Path.Combine(heroesPath, GetHeroConfigurationFileName(hero)), document.ToString());
    }
}

CheckSkillTreeExists();

var randomizer = new DefaultSkillTreeRandomizer(new ConsoleLogger());
var heroes = randomizer.Generate();

CheckHeroConfigurationsExist(heroes);

var outputPath = GetOutputPath();

if (Directory.Exists(outputPath))
{
    Directory.Delete(outputPath, true);
}

WriteSkillTree(outputPath, heroes);

WriteHeroConfigurations(outputPath, heroes);

Exit("Done!");
