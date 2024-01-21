namespace Kakt.Modding.Domain.Skills.PoisonCut.Upgrades;

public class PoisonCutUpgrade : SkillUpgrade
{
    public PoisonCutUpgrade()
    {
        Prerequisite = nameof(PoisonCut);
    }
}
