namespace Kakt.Modding.Core.Skills.MasterOfIce;

[ConfigurationElement("MasterofIce")]
[SkillAttributes(SkillAttributes.Ice)]
[RequiresEffects(Effects.Chill | Effects.Freeze)]
public class MasterOfIce : UpgradablePassiveSkill
{
    public override string Name => "Hero_sage__masterOfice";
}
