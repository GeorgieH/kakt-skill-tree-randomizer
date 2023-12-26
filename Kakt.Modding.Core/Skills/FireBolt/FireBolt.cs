namespace Kakt.Modding.Core.Skills.FireBolt;

[SkillAttributes(SkillAttributes.Ranged | SkillAttributes.Spell | SkillAttributes.Fire)]
[CausesEffect(Effect.Burning)]
[CausesEffect(Effect.Knockback)]
public class FireBolt : ActiveSkill
{
    public override string Name => "Merlin__fireBolt";
}
