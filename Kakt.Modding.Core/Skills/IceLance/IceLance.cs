namespace Kakt.Modding.Core.Skills.IceLance;

[SkillAttributes(SkillAttributes.Ranged | SkillAttributes.Spell)]
[CausesEffects(Effects.Chill)]
public class IceLance : ActiveSkill
{
    public override string Name => "Hero_sage__iceLance";
}
