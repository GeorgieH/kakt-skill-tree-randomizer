namespace Kakt.Modding.Core.Skills.ForceCleave;

[SkillAttributes(SkillAttributes.Melee | SkillAttributes.Area)]
[CausesEffects(Effects.Knockback)]
public class ForceCleave : ActiveSkill
{
    public override string Name => "FaerieKnight__forceCleave";
}
