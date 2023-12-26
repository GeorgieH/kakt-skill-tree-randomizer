namespace Kakt.Modding.Core.Skills.IceBolt;

[SkillAttributes(SkillAttributes.Ranged | SkillAttributes.Spell)]
[CausesEffects(Effects.Chill)]
public class IceBolt : ActiveSkill
{
    public override string Name => "Morgana__iceBolt";
}
