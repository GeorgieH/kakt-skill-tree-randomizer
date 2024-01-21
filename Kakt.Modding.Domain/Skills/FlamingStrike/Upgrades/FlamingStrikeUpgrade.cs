namespace Kakt.Modding.Domain.Skills.FlamingStrike.Upgrades;

public class FlamingStrikeUpgrade : SkillUpgrade
{
    public FlamingStrikeUpgrade()
    {
        Prerequisite = nameof(FlamingStrike);
    }
}
