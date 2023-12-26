namespace Kakt.Modding.Core.Skills.LightningStrike;

[SkillAttributes(SkillAttributes.Melee | SkillAttributes.Lightning)]
[CausesEffects(Effects.Shock)]
public class LightningStrike : ActiveSkill
{
    public override string Name => "FaerieKnight__LightningStrike";
}
