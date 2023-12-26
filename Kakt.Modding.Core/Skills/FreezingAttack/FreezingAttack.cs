namespace Kakt.Modding.Core.Skills.FreezingAttack;

[SkillAttributes(SkillAttributes.Melee)]
[CausesEffects(Effects.Freeze)]
public class FreezingAttack : ActiveSkill
{
    public override string Name => "Hero_sage__freezingAttack";
}
