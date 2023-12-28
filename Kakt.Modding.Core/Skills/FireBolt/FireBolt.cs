namespace Kakt.Modding.Core.Skills.FireBolt;

[SkillAttributes(SkillAttributes.Ranged | SkillAttributes.Spell | SkillAttributes.Fire)]
[CausesEffects(Effects.Burn | Effects.Knockback)]
public class FireBolt : ActiveSkill
{
    public override string Name => "Merlin__fireBolt";
}
