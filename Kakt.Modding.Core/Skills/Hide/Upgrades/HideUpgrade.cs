namespace Kakt.Modding.Core.Skills.Hide.Upgrades;

public abstract class HideUpgrade : SkillUpgrade
{
    public override string Prerequisite => nameof(Hide);
}
