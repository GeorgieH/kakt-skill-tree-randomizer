using Kakt.Modding.Cli;
using Kakt.Modding.Configuration;
using Kakt.Modding.Configuration.SkillTree;
using Kakt.Modding.Core.Heroes;
using Kakt.Modding.Core.Heroes.Configuration;
using Kakt.Modding.Core.Skills;
using Kakt.Modding.Domain.Heroes;
using Kakt.Modding.Randomization.Skills;
using Kakt.Modding.Randomization.Skills.Default;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Xml.Linq;

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

static string GetLocalPath()
{
    return AppDomain.CurrentDomain.BaseDirectory;
}

static string GetCfgPath()
{
    return Path.Combine(GetLocalPath(), "Cfg");
}

static string GetOutputPath()
{
    return Path.Combine(GetLocalPath(), "King Arthur Knight's Tale");
}

static string GetSkillTreePath()
{
    return Path.Combine(GetCfgPath(), FileNames.SkillTree);
}

static string GetRandomizationConfiguration()
{
    var path = Path.Combine(GetLocalPath(), "randomization_config.json");

    if (!File.Exists(path))
    {
        Exit(GetFileNotFoundMessage(path));
    }

    return File.ReadAllText(path, Encoding.UTF8);
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
        SirGawain => FileNames.SirGawain,
        SirGeraint => FileNames.SirGeraint,
        SirKay => FileNames.SirKay,
        SirLancelot => FileNames.SirLancelot,
        SirLanval => FileNames.SirLanval,
        SirLeodegrance => FileNames.SirLeodegrance,
        SirLucan => FileNames.SirLucan,
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
    return Path.Combine(GetCfgPath(), GetHeroConfigurationFileName(hero));
}

static void WriteFile(string path, string content)
{
    File.WriteAllText(path, content, new UTF8Encoding(false));
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

static bool HeroDoesNotRequireConfiguration(Hero hero)
{
    return hero is SirMordred;
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
        if (HeroDoesNotRequireConfiguration(hero))
        {
            continue;
        }

        var result = CheckHeroConfigurationExists(hero, out var path);

        if (!result)
        {
            Console.WriteLine(GetFileNotFoundMessage(path));
            exit = true;
        }
    }

    if (exit)
    {
        Exit("(ERROR) One or more hero .cfg files not found");
    }
}

static void WritePreset(CfgDocument document, Preset preset)
{
    var starterSkills = preset.LearnedSkills
        .Where(s => s is Skill skill && skill.Starter);

    var learnedSkills = preset.LearnedSkills
        .Except(starterSkills)
        .Select(s => s.ConfigurationName);

    var value = string.Join(",", learnedSkills);
    var property = (CfgProperty)document["Hero"]!["Presets"]![preset.Name]!["LearnedSkills"]!;
    property.Value = value;
}

static void WriteMerlinPresets(string outputPath, Merlin merlin)
{
    var hermitPath = Path.Combine(GetCfgPath(), FileNames.MerlinHermit);
    var hermitDocument = CfgDocument.Parse(hermitPath);
    var hermitPreset = merlin.Presets[0];
    WritePreset(hermitDocument, hermitPreset);

    var hermitProperty = (CfgProperty)hermitDocument["Hero"]!["Components"]!["caster"]!["Skills"]!;
    var skills = new ActiveSkill?[]
    {
        merlin.SkillTree.TierOneActiveSkillOne,
        merlin.SkillTree.TierOneActiveSkillTwo,
        merlin.SkillTree.TierOneActiveSkillThree
    }.Select(s => s!.Name);
    hermitProperty.Value = $"{string.Join(",", skills)},Hero_arcanist__passive,death";

    WriteFile(Path.Combine(outputPath, FileNames.MerlinHermit), hermitDocument.ToString());

    var merlinPath = Path.Combine(GetCfgPath(), FileNames.Merlin);
    var merlinDocument = CfgDocument.Parse(merlinPath);
    var merlinPreset = merlin.Presets[1];
    WritePreset(merlinDocument, merlinPreset);

    WriteFile(Path.Combine(outputPath, FileNames.Merlin), merlinDocument.ToString());
}

static void WriteHeroConfigurations(string outputPath, IEnumerable<Hero> heroes)
{
    var heroesPath = Path.Combine(outputPath, "Cfg", "Actors", "Heroes");
    Directory.CreateDirectory(heroesPath);

    foreach (var hero in heroes)
    {
        if (HeroDoesNotRequireConfiguration(hero))
        {
            continue;
        }

        if (hero is Merlin)
        {
            WriteMerlinPresets(heroesPath, (Merlin)hero);
            continue;
        }

        var configPath = GetHeroConfigurationFilePath(hero);
        var document = CfgDocument.Parse(configPath);

        foreach (var preset in hero.Presets)
        {
            WritePreset(document, preset);
        }

        if (hero is LadyDindraine
            || hero is SirBalan
            || hero is SirBalin
            || hero is SirKay
            || hero is SirPelleas)
        {
            var starterSkills = hero.SkillTree.StarterSkills.Select(s => s!.Name);
            var property = (CfgProperty)document["Hero"]!["Components"]!["caster"]!["skills"]!;
            property.Value = $"{string.Join(",", starterSkills)},unit__passive,death";
        }

        if (hero is RedKnight)
        {
            var property = (CfgProperty)document["Hero"]!["Components"]!["caster"]!["skills"]!;
            property.Value = $"{hero.SkillTree.TierOneActiveSkillThree!.Name},unit__passive,death";
        }

        if (hero is SirDagonet
            || hero is SirEctor)
        {
            var starterSkills = hero.SkillTree.StarterSkills.Select(s => s!.Name);
            var property = (CfgProperty)document["Hero"]!["Components"]!["caster"]!["skills"]!;
            property.Value = $"{string.Join(",", starterSkills)},Hero_arcanist__passive,death";
        }

        WriteFile(Path.Combine(heroesPath, GetHeroConfigurationFileName(hero)), document.ToString());
    }
}

CheckSkillTreeExists();

var randomizationConfig = GetRandomizationConfiguration();
var config = JsonSerializer.Deserialize<RandomizationConfiguration>(randomizationConfig);

var randomizer = new DefaultSkillTreeRandomizer(new ConsoleLogger());

IEnumerable<Hero> heroes = null!;

try
{
    heroes = randomizer.Generate(config!.Profiles.Default);
}
catch (InvalidSkillTypeException ex)
{
    Exit($"(ERROR) Invalid skill type: {ex.Skill}");
}

CheckHeroConfigurationsExist(heroes);

var outputPath = GetOutputPath();

if (Directory.Exists(outputPath))
{
    Directory.Delete(outputPath, true);
}

WriteSkillTree(outputPath, heroes);
WriteHeroConfigurations(outputPath, heroes);

Exit("Done!");
