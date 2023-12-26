namespace Kakt.Modding.Core.Skills.BleedingStrike;

[SkillAttributes(SkillAttributes.Melee)]
[CausesEffect(Effect.Bleeding)]
public class BleedingStrike : ActiveSkill
{
    public override string Name => "RedKnight__bleedingStrike";
}
