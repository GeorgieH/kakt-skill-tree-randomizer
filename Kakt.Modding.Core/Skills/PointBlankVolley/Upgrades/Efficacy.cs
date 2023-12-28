namespace Kakt.Modding.Core.Skills.PointBlankVolley.Upgrades;

public class Efficacy : SkillUpgrade<PointBlankVolley>
{
    public Efficacy()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_marksman__pointBlankVolley_efficacy";
}
