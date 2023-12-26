namespace Kakt.Modding.Core.Skills.FireArrow;

[ConfigurationElement("FireBolt")]
[SkillAttributes(SkillAttributes.Ranged | SkillAttributes.Fire)]
[CausesEffects(Effects.Burn)]
public class FireArrow : ActiveSkill
{
    public override string Name => "Hero_marksman__fireBolt";
}
