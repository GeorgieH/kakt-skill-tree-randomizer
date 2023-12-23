namespace Kakt.Modding.Core.Skills.JumpingAttack.Upgrades;

public abstract class JumpingAttackUpgrade : SkillUpgrade
{
    public override string Prerequisite => nameof(JumpingAttack);
}
