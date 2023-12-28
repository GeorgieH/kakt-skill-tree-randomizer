namespace Kakt.Modding.Core.Skills.Dash.Upgrades;

public class Persistence : SkillUpgrade<Dash>
{
    public Persistence()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_marksman__dash_persistence";
}
