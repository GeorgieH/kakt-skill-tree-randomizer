namespace Kakt.Modding.Domain.Skills.ForceBolt.Upgrades;

public class ForceBoltUpgrade : SkillUpgrade
{
    public ForceBoltUpgrade()
    {
        Prerequisite = nameof(ForceBolt);
    }
}
