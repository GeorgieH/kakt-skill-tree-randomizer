namespace Kakt.Modding.Core.Skills.FreezingAttack;

[SkillAttributes(SkillAttributes.Melee | SkillAttributes.Ice)]
[CausesEffects(Effects.Freeze)]
public class FreezingAttack : ActiveSkill
{
    public override string Name => "Hero_sage__freezingAttack";
}
