namespace Kakt.Modding.Core.Skills.MasterOfHexes;

[ConfigurationElement("MasterOfcurses")]
[RequiresSkillWithAttribute(SkillAttributes.Hex)]
public class MasterOfHexes : UpgradablePassiveSkill
{
    public override string Name => "Hero_arcanist__masterOfcurses";
}
