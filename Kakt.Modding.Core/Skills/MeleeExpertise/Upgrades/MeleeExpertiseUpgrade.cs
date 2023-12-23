namespace Kakt.Modding.Core.Skills.MeleeExpertise.Upgrades;

public abstract class MeleeExpertiseUpgrade : SkillUpgrade
{
    public override string Prerequisite => nameof(MeleeExpertise);
}
