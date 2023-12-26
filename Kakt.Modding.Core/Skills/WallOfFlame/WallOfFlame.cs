namespace Kakt.Modding.Core.Skills.WallOfFlame;

[ConfigurationElement("WallofFlame")]
[SkillAttributes(SkillAttributes.Ranged | SkillAttributes.Spell | SkillAttributes.Fire | SkillAttributes.Area)]
[CausesEffect(Effect.Burning)]
public class WallOfFlame : ActiveSkill
{
    public override string Name => "Hero_arcanist__wallOfflame";
}
