namespace Kakt.Modding.Core.Skills.IceBolt;

[SkillAttributes(SkillAttributes.Ranged | SkillAttributes.Spell | SkillAttributes.Ice)]
[CausesEffects(Effects.Chill)]
public class IceBolt : ActiveSkill
{
    public override string Name => "Morgana__iceBolt";
}
