namespace Kakt.Modding.Core.Skills.PoisonBomb;

[SkillAttributes(SkillAttributes.Ranged | SkillAttributes.Area)]
[CausesEffects(Effects.Poison)]
public class PoisonBomb : ActiveSkill
{
    public override string Name => "Hero_marksman__poisonBomb";
}
