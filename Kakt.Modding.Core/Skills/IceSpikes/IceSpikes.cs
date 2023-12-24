namespace Kakt.Modding.Core.Skills.IceSpikes;

[SkillAttributes(SkillAttributes.Ranged | SkillAttributes.Spell | SkillAttributes.Area)]
[CausesEffect(Effect.Chill)]
public class IceSpikes : ActiveSkill
{
    public override string Name => "Hero_sage__iceSpikes";
}
