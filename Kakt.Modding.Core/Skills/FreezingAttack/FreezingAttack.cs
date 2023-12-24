namespace Kakt.Modding.Core.Skills.FreezingAttack;

[SkillAttributes(SkillAttributes.Melee)]
[CausesEffect(Effect.Frozen)]
public class FreezingAttack : ActiveSkill
{
    public override string Name => "Hero_sage__freezingAttack";
}
