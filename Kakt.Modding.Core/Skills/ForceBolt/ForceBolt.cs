namespace Kakt.Modding.Core.Skills.ForceBolt;

[SkillAttributes(SkillAttributes.Ranged | SkillAttributes.Spell)]
[CausesEffect(Effect.Knockback)]
public class ForceBolt : ActiveSkill
{
    public override string Name => "Hero_arcanist__forceBolt";
}
