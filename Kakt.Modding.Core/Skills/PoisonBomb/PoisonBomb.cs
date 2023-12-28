namespace Kakt.Modding.Core.Skills.PoisonBomb;

[ConfigurationElement(nameof(PoisonBomb))]
[SkillAttributes(SkillAttributes.Ranged | SkillAttributes.Area)]
[CausesEffects(Effects.Poison)]
public class PoisonBomb : ActiveSkill
{
    public override string Name => "Hero_marksman__poisonBomb";
}
