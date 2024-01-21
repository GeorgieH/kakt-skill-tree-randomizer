namespace Kakt.Modding.Domain.Skills.ShadowBolt.Upgrades;

public class ShadowBoltUpgrade : SkillUpgrade
{
    public ShadowBoltUpgrade()
    {
        Prerequisite = nameof(ShadowBolt);
    }
}
