namespace Kakt.Modding.Core.Skills.DebilitatingThrow.Upgrades;

public abstract class DebilitatingThrowUpgrade : SkillUpgrade
{
    public override string Prerequisite => nameof(DebilitatingThrow);
}
