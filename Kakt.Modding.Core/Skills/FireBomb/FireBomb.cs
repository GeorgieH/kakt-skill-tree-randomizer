namespace Kakt.Modding.Core.Skills.FireBomb;

[SkillAttributes(SkillAttributes.Ranged | SkillAttributes.Area)]
[CausesEffect(Effect.Burning)]
public class FireBomb : ActiveSkill
{
    public override string Name => "Hero_marksman__fireBomb";
}
