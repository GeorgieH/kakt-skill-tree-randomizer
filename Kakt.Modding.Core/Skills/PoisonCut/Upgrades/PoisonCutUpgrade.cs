namespace Kakt.Modding.Core.Skills.PoisonCut.Upgrades;

public abstract class PoisonCutUpgrade : SkillUpgrade
{
    public override string Prerequisite => nameof(PoisonCut);
}
