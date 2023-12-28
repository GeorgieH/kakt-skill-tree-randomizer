namespace Kakt.Modding.Core.Skills.BleedingStrike;

[SkillAttributes(SkillAttributes.Melee)]
[CausesEffects(Effects.Bleed)]
public class BleedingStrike : ActiveSkill
{
    public override string Name => "RedKnight__bleedingStrike";
}
