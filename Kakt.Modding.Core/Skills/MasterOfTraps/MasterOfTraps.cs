namespace Kakt.Modding.Core.Skills.MasterOfTraps;

[ConfigurationElement("MasterofTraps")]
[RequiresSkillWithAttribute(SkillAttributes.Trap)]
public class MasterOfTraps : UpgradablePassiveSkill
{
    public override string Name => "Hero_vanguard__masterOftraps";
}
