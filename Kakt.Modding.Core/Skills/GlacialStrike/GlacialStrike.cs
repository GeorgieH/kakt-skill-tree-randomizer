namespace Kakt.Modding.Core.Skills.GlacialStrike;

[SkillAttributes(SkillAttributes.Ranged | SkillAttributes.Spell)]
[CausesEffects(Effects.Chill)]
public class GlacialStrike : ActiveSkill
{
    public override string Name => "Morgana__glacialStrike";
}
