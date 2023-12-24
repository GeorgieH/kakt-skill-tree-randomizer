namespace Kakt.Modding.Core.Skills.SlowingHex;

[ConfigurationElement("Curse")]
[SkillAttributes(SkillAttributes.Ranged | SkillAttributes.Spell | SkillAttributes.Hex)]
[CausesEffect(Effect.Slow)]
public class SlowingHex : ActiveSkill
{
    public override string Name => "Hero_arcanist__curse";
}
