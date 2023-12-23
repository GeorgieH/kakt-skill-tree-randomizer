namespace Kakt.Modding.Core.Skills.MarkTarget.Upgrades;

public abstract class MarkTargetUpgrade : SkillUpgrade
{
    public override string Prerequisite => nameof(MarkTarget);
}
