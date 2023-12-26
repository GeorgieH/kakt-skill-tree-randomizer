namespace Kakt.Modding.Core.Skills.ShieldCharge;

[SkillAttributes(SkillAttributes.Movement | SkillAttributes.Melee)]
[CausesEffects(Effects.Knockback | Effects.Knockdown)]
public class ShieldCharge : ActiveSkill
{
    public override string Name => "Hero_defender__shieldCharge";
}
