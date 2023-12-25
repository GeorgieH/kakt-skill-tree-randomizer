namespace Kakt.Modding.Core.Skills.FireBolt;

[SkillAttributes(SkillAttributes.Ranged | SkillAttributes.Spell)]
[CausesEffect(Effect.Burning)]
[CausesEffect(Effect.Knockback)]
public class FireBolt : ActiveSkill
{
    public override string Name => "Merlin__fireBolt";
}
