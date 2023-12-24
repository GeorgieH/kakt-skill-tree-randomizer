namespace Kakt.Modding.Core.Skills.PoisonedArrow;

[ConfigurationElement("PoisonedBolt")]
[SkillAttributes(SkillAttributes.Ranged)]
[CausesEffect(Effect.Poison)]
public class PoisonedArrow : ActiveSkill
{
    public override string Name => "Hero_marksman__poisonedBolt";
}
