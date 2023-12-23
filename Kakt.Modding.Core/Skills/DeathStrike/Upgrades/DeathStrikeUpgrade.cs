namespace Kakt.Modding.Core.Skills.DeathStrike.Upgrades;

public abstract class DeathStrikeUpgrade : SkillUpgrade
{
    public override string Prerequisite => nameof(DeathStrike);
}
