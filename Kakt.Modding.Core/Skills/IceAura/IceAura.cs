namespace Kakt.Modding.Core.Skills.IceAura;

[SkillAttributes(SkillAttributes.Spell | SkillAttributes.Ice | SkillAttributes.Area)]
[CausesEffects(Effects.Chill)]
public class IceAura : ActiveSkill
{
    public override string Name => "Hero_sage__iceAura";
}
