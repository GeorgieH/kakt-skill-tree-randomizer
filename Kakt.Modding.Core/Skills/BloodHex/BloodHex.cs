namespace Kakt.Modding.Core.Skills.BloodHex;

[ConfigurationElement("BloodCurse")]
[SkillAttributes(SkillAttributes.Ranged | SkillAttributes.Spell | SkillAttributes.Hex)]
[CausesEffect(Effect.Bleeding)]
public class BloodHex : ActiveSkill
{
    public override string Name => "Hero_arcanist__bloodCurse";
}
