namespace Kakt.Modding.Core.Skills.FrostArmour.Upgrades;

public class Hardened : SkillUpgrade<FrostArmour>
{
    public Hardened()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_sage__frostArmour_hardened";
}
