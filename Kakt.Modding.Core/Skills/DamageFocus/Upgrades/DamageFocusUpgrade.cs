namespace Kakt.Modding.Core.Skills.DamageFocus.Upgrades;

public abstract class DamageFocusUpgrade : SkillUpgrade
{
    public override string Prerequisite => nameof(DamageFocus);
}
