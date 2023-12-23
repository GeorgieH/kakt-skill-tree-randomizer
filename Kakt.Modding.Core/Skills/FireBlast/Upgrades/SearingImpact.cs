namespace Kakt.Modding.Core.Skills.FireBlast.Upgrades;

public class SearingImpact : SkillUpgrade<FireBlast>
{
    public SearingImpact()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_arcanist__fireBlast_searingImpact";
}
