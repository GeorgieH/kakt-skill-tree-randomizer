namespace Kakt.Modding.Core.Skills.DebilitatingThrow;

[SkillAttributes(SkillAttributes.Ranged)]
[CausesEffect(Effect.Knockback)]
[CausesEffect(Effect.Knockdown)]
public class DebilitatingThrow : ActiveSkill
{
    public override string Name => "Hero_vanguard__debilitatingThrow";
}
