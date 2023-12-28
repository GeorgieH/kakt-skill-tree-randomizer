namespace Kakt.Modding.Core.Skills.FireArrow.Upgrades;

public class ExplosiveArrow : SkillUpgrade<FireArrow>
{
    public ExplosiveArrow()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_marksman__fireBolt_explosiveBolt";
}
