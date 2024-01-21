namespace Kakt.Modding.Core.KnightsTale.Skills;

public interface ISkill
{
    string CodeName { get; set; }
    string ConfigurationName { get; }
    Effects Effects { get; }
    string? IconName { get; set; }
    SkillTier Tier { get; }
}
