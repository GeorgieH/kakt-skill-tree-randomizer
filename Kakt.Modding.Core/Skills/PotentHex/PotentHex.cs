namespace Kakt.Modding.Core.Skills.PotentHex;

[ConfigurationElement("PotentCurse")]
[RequiresSkillWithAttribute(SkillAttributes.Hex)]
public class PotentHex : PassiveSkill
{
    public override string Name => "Hero_arcanist__potentCurse";
}
