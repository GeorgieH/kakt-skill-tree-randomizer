namespace Kakt.Modding.Domain.Skills.Shoot.Upgrades;

public class ShootUpgrade : SkillUpgrade
{
    public ShootUpgrade()
    {
        Prerequisite = nameof(Shoot);
    }
}
