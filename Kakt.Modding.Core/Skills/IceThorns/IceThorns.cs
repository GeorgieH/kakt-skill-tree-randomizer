namespace Kakt.Modding.Core.Skills.IceThorns;

[SkillAttributes(SkillAttributes.Ranged | SkillAttributes.Spell | SkillAttributes.Ice | SkillAttributes.Area)]
[CausesEffects(Effects.Chill)]
public class IceThorns : ActiveSkill
{
    public override string Name => "Morgana__iceThorns";
}
