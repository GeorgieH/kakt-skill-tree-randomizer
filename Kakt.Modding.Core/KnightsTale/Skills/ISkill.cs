namespace Kakt.Modding.Core.KnightsTale.Skills;

public interface ISkill
{
    string CodeName { get; set; }
    string ConfigurationName { get; set; }
    string? IconName { get; set; }
    SkillTier Tier { get; set; }
}
