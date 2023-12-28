namespace Kakt.Modding.Core.Skills.LightningArrow;

[SkillAttributes(SkillAttributes.Ranged | SkillAttributes.Lightning)]
[CausesEffects(Effects.Shock)]
public class LightningArrow : ActiveSkill
{
    public override string Name => "SirGeraint__lightningArrow";
}
