namespace Kakt.Modding.Core.Skills.MasterOfLightning;

[ConfigurationElement("MasterofLightning")]
[RequiresSkillWithAttribute(SkillAttributes.Lightning)]
public class MasterOfLightning : UpgradablePassiveSkill
{
    public override string Name => "Hero_sage__masterofLightning";
}
