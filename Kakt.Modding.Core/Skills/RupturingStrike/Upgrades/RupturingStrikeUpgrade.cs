namespace Kakt.Modding.Core.Skills.RupturingStrike.Upgrades;

public abstract class RupturingStrikeUpgrade : SkillUpgrade
{
    public override string Prerequisite => nameof(RupturingStrike);
}
