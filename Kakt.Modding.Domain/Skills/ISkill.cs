namespace Kakt.Modding.Domain.Skills;

public interface ISkill
{
    string ConfigurationName { get; set; }
    string? IconName { get; set; }
    string Name { get; }
    string CodeName { get; }
    SkillTier Tier { get; }
    string GetCodeNameOrOverride();
    void OverrideCodeName(string nameOverride);
}
