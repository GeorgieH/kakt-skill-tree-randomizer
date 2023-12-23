namespace Kakt.Modding.Core.Skills.Dash.Upgrades;

public class ExtendedDash : SkillUpgrade<Dash>
{
    public ExtendedDash()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_marksman__dash_extendedDash";
}
