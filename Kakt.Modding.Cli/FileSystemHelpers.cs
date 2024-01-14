using Kakt.Modding.Domain.Heroes;
using System.Text;

namespace Kakt.Modding.Cli;

public static class FileSystemHelpers
{
    public static string GetLocalPath()
    {
        return AppDomain.CurrentDomain.BaseDirectory;
    }

    public static string GetCfgPath()
    {
        return Path.Combine(GetLocalPath(), "Resources", "Knight's Tale", "Cfg");
    }

    public static string GetOutputPath()
    {
        return Path.Combine(GetLocalPath(), "King Arthur Knight's Tale");
    }

    public static string GetSkillTreePath()
    {
        return Path.Combine(GetCfgPath(), FileNames.SkillTree);
    }

    public static void WriteFile(string path, string content)
    {
        File.WriteAllText(path, content, new UTF8Encoding(false));
    }

    public static string GetHeroConfigurationFileName(Hero hero)
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
}
