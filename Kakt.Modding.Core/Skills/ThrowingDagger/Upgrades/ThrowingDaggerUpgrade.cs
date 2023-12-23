namespace Kakt.Modding.Core.Skills.ThrowingDagger.Upgrades;

public abstract class ThrowingDaggerUpgrade : SkillUpgrade
{
    public override string Prerequisite => nameof(ThrowingDagger);
}
