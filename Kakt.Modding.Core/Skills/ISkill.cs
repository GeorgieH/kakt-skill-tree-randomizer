namespace Kakt.Modding.Core.Skills;

public interface ISkill
{
    string ConfigurationName { get; set; }
    string? IconName { get; set; }
    string Name { get; }
    SkillTier Tier { get; }
    string GetNameOrOverride();
    void OverrideName(string nameOverride);
}
