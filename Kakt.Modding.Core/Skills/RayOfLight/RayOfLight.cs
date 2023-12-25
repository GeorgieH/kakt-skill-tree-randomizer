namespace Kakt.Modding.Core.Skills.RayOfLight;

[ConfigurationElement("RayofLight")]
[SkillAttributes(SkillAttributes.Ranged | SkillAttributes.Spell)]
[CausesEffect(Effect.Blind)]
public class RayOfLight : ActiveSkill
{
    public override string Name => "Hero_sage__rayofLight";
}
