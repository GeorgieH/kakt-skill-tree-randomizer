namespace Kakt.Modding.Core.Skills.FireBlast;

[SkillAttributes(SkillAttributes.Ranged | SkillAttributes.Spell | SkillAttributes.Fire | SkillAttributes.Area)]
[CausesEffect(Effect.Burning)]
public class FireBlast : ActiveSkill
{
    public override string Name => "Hero_arcanist__fireBlast";
}
