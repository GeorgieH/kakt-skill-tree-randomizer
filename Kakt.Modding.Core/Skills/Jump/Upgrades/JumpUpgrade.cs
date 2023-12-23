namespace Kakt.Modding.Core.Skills.Jump.Upgrades;

public abstract class JumpUpgrade : SkillUpgrade
{
    public override string Prerequisite => nameof(Jump);
}
