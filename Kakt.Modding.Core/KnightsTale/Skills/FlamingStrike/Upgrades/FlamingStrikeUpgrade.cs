namespace Kakt.Modding.Core.KnightsTale.Skills.FlamingStrike.Upgrades;

public class FlamingStrikeUpgrade : SkillUpgradeInfo
{
    public FlamingStrikeUpgrade()
    {
        Prerequisite = nameof(FlamingStrike);
    }
}
