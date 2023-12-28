namespace Kakt.Modding.Core.Skills.Cleave;

[ConfigurationElement("Cleeve")]
[SkillAttributes(SkillAttributes.Melee | SkillAttributes.Area)]
public class Cleave : ActiveSkill
{
    public override string Name => "Hero_champion__cleave";
}
