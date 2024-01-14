namespace Kakt.Modding.Domain.Skills.IceBolt.Upgrades;

public class IceBoltUpgrade : SkillUpgrade
{
    public IceBoltUpgrade()
    {
        Prerequisite = nameof(IceBolt);
    }
}
