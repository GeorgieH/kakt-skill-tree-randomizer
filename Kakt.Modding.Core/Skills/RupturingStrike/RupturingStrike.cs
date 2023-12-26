namespace Kakt.Modding.Core.Skills.RupturingStrike;

[SkillAttributes(SkillAttributes.Melee)]
[CausesEffects(Effects.Bleed)]
public class RupturingStrike : ActiveSkill
{
    public override string Name => "Hero_champion__rupturingStrike";
}
