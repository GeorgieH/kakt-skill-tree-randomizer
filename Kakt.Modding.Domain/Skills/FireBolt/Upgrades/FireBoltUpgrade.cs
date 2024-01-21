namespace Kakt.Modding.Domain.Skills.FireBolt.Upgrades;

public class FireBoltUpgrade : SkillUpgrade
{
    public FireBoltUpgrade()
    {
        Prerequisite = nameof(FireBolt);
    }
}
