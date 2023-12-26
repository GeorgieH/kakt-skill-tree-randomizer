namespace Kakt.Modding.Core.Skills.CleansingFire;

[SkillAttributes(SkillAttributes.Ranged | SkillAttributes.Spell | SkillAttributes.Fire)]
[CausesEffect(Effect.Burning)]
public class CleansingFire : ActiveSkill
{
    public override string Name => "Hero_sage__cleansingFire";
}
