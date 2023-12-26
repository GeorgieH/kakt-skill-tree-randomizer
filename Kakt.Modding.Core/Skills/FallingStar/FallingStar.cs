namespace Kakt.Modding.Core.Skills.FallingStar;

[SkillAttributes(SkillAttributes.Ranged | SkillAttributes.Spell | SkillAttributes.Fire | SkillAttributes.Area)]
[CausesEffect(Effect.Knockback)]
public class FallingStar : ActiveSkill
{
    public override string Name => "Hero_arcanist__fallingStar";
}
