namespace Kakt.Modding.Core.Skills.ThunderStorm.Upgrades;

public class GreaterStorm : SkillUpgrade<ThunderStorm>
{
    public GreaterStorm()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_sage__thunderStorm_greaterStorm";
}
