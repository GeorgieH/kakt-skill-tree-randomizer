namespace Kakt.Modding.Core.Skills;

public interface ISkill
{
    string? IconName { get; set; }
    string Name { get; }
    SkillTier Tier { get; }
    string GetNameOrOverride();
    void OverrideName(string nameOverride);
}
