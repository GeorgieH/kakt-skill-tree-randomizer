namespace Kakt.Modding.Domain.Skills.LightningStrike.Upgrades;

public class LightningStrikeUpgrade : SkillUpgrade
{
    public LightningStrikeUpgrade()
    {
        Prerequisite = nameof(LightningStrike);
    }
}
