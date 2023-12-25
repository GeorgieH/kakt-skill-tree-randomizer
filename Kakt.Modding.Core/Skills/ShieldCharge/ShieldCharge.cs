namespace Kakt.Modding.Core.Skills.ShieldCharge;

[SkillAttributes(SkillAttributes.Movement | SkillAttributes.Melee)]
[CausesEffect(Effect.Knockback)]
[CausesEffect(Effect.Knockdown)]
public class ShieldCharge : ActiveSkill
{
    public override string Name => "Hero_defender__shieldCharge";
}
