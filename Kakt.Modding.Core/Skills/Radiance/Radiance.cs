namespace Kakt.Modding.Core.Skills.Radiance;

[SkillAttributes(SkillAttributes.Area | SkillAttributes.Spell)]
[CausesEffects(Effects.Blind)]
public class Radiance : ActiveSkill
{
    public override string Name => "SirLancelot__radiance";
}
