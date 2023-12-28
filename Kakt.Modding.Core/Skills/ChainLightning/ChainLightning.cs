namespace Kakt.Modding.Core.Skills.ChainLightning;

[ConfigurationElement(nameof(ChainLightning))]
[SkillAttributes(SkillAttributes.Ranged | SkillAttributes.Spell | SkillAttributes.Lightning)]
public class ChainLightning : ActiveSkill
{
    public override string Name => "SirMordred__chainLightning";
}
