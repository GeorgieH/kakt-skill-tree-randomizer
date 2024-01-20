using Kakt.Modding.Core.KnightsTale.Heroes;
using System.Text;

namespace Kakt.Modding.Cli.KnightsTale;

public interface IFileSystemService
{
    string BaseDirectory { get; }
    string OutputDirectory { get; }
    string RandomizationConfigurationPath { get; }
    string SkillInfoDirectory { get; }
    string SkillTreeOutputDirectory { get; }
    string HeroesOutputDirectory { get; }

    void DeleteDirectory(string path);
    bool DirectoryExists(string path);
    string GetCfgPath(string fileName);
    IEnumerable<string> GetDirectories(string path);
    IEnumerable<string> GetFiles(string path);
    string GetFileText(string path);
    string GetHeroConfigurationFileName(Hero hero);
    string GetSkillUpgradesDirectory(string basePath);
    void WriteDocument(string directory, string fileName, string content);
}

public class FileSystemService : IFileSystemService
{
    private static readonly string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
    private static readonly string randomizationConfigurationPath = Path.Combine(baseDirectory, "knights_tale_config.json");
    private static readonly string cfgDirectory = Path.Combine(baseDirectory, "Resources", "Knight's Tale", "Cfg");
    private static readonly string outputDirectory = Path.Combine(baseDirectory, "King Arthur Knight's Tale");
    private static readonly string skillTreeOutputDirectory = Path.Combine(outputDirectory, "Cfg", "Config");
    private static readonly string heroesOutputDirectory = Path.Combine(outputDirectory, "Cfg", "Actors", "Heroes");
    private static readonly string relativeSkillsDirectory = Path.Combine("Resources", "Knight's Tale", "Skills");
    private static readonly string skillInfoDirectory = Path.Combine(baseDirectory, relativeSkillsDirectory);
    
    public string BaseDirectory => baseDirectory;
    public string HeroesOutputDirectory => heroesOutputDirectory;
    public string OutputDirectory => outputDirectory;
    public string RandomizationConfigurationPath => randomizationConfigurationPath;
    public string SkillInfoDirectory => skillInfoDirectory;
    public string SkillTreeOutputDirectory => skillTreeOutputDirectory;

    public IEnumerable<string> GetDirectories(string path)
    {
        return Directory.EnumerateDirectories(path);
    }

    public IEnumerable<string> GetFiles(string path)
    {
        return Directory.EnumerateFiles(path);
    }

    public string GetFileText(string path)
    {
        return File.ReadAllText(path);
    }

    public string GetSkillUpgradesDirectory(string basePath)
    {
        return Path.Combine(basePath, "Upgrades");
    }

    public bool DirectoryExists(string path)
    {
        return Directory.Exists(path);
    }

    public string GetCfgPath(string fileName)
    {
        return Path.Combine(cfgDirectory, fileName);
    }

    public void DeleteDirectory(string path)
    {
        Directory.Delete(path, true);
    }

    public void WriteDocument(string directory, string fileName, string content)
    {
        Directory.CreateDirectory(directory);
        File.WriteAllText(Path.Combine(directory, fileName), content, new UTF8Encoding(false));
    }

    public string GetHeroConfigurationFileName(Hero hero) => hero switch
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