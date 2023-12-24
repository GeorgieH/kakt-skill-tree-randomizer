namespace Kakt.Modding.Core.Skills.DeathHex;

[ConfigurationElement("DeathCurse")]
[SkillAttributes(SkillAttributes.Ranged | SkillAttributes.Spell | SkillAttributes.Hex)]
public class DeathHex : ActiveSkill
{
    public override string Name => "Hero_arcanist__deathCurse";
}
