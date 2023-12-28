namespace Kakt.Modding.Core.Skills.MindFog;

[SkillAttributes(SkillAttributes.Ranged | SkillAttributes.Spell)]
[CausesEffects(Effects.Chill)]
public class MindFog : ActiveSkill
{
    public override string Name => "Hero_arcanist__mindFog";
}
