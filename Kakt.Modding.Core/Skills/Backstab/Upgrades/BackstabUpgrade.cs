namespace Kakt.Modding.Core.Skills.Backstab.Upgrades;

public abstract class BackstabUpgrade : SkillUpgrade
{
    public override string Prerequisite => nameof(Backstab);
}
