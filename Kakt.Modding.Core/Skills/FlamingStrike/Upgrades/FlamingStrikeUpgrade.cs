namespace Kakt.Modding.Core.Skills.FlamingStrike.Upgrades;

public abstract class FlamingStrikeUpgrade : SkillUpgrade
{
    public override string Prerequisite => nameof(FlamingStrike);
}
