namespace Kakt.Modding.Domain.Skills.Strike;

public class StrikeUpgrade : SkillUpgrade
{
    public StrikeUpgrade()
    {
        Prerequisite = nameof(Strike);
    }
}
