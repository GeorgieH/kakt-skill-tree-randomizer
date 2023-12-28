namespace Kakt.Modding.Core.Skills.HolyArmour.Upgrades;

public class Martyrdom : SkillUpgrade<HolyArmour>
{
    public Martyrdom()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "WhiteKnight__holyArmour_martyrdom";
}
