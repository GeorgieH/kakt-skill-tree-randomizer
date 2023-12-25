namespace Kakt.Modding.Core.Skills.MindFog;

[SkillAttributes(SkillAttributes.Ranged | SkillAttributes.Spell)]
[CausesEffect(Effect.Chill)]
public class MindFog : ActiveSkill
{
    public override string Name => "Hero_arcanist__mindFog";
}
