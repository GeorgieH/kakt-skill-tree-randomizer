namespace Kakt.Modding.Core.Skills.Dash.Upgrades;

public abstract class DashUpgrade : SkillUpgrade
{
    public override string Prerequisite => nameof(Dash);
}
