namespace Kakt.Modding.Core.Skills.CastStigma;

[SkillAttributes(SkillAttributes.Ranged | SkillAttributes.Spell | SkillAttributes.Hex)]
[CausesEffects(Effects.Vulnerability)]
public class CastStigma : ActiveSkill
{
    public override string Name => "SirMordred__castStigma";
}
