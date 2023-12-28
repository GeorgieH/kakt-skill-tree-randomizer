namespace Kakt.Modding.Core.Skills.DebilitatingThrow;

[SkillAttributes(SkillAttributes.Ranged)]
[CausesEffects(Effects.Knockback | Effects.Knockdown)]
public class DebilitatingThrow : ActiveSkill
{
    public override string Name => "Hero_vanguard__debilitatingThrow";
}
