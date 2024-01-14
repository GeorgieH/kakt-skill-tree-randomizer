
namespace Kakt.Modding.Domain.Skills;

public class SkillUpgrade : ISkill, IEquatable<SkillUpgrade?>
{
    private string? codeNameOverride;
    private string? prerequisiteOverride;

    public string Name { get; set; }
    public string CodeName { get; set; }
    public string ConfigurationName { get; set; }
    public string? IconName { get; set; }
    public Effects Effects { get; set; }
    public Effects PrerequisiteEffects { get; set; }
    public SkillTier Tier { get; set; }
    public SkillUpgradeType Type => SkillUpgradeType.Mastery;
    public int LevelLimit { get; set; }
    public Position2D IconPosition { get; set; }
    public int Cost => SkillCosts.One;
    public string Prerequisite { get; set; }

    public SkillUpgrade Copy()
    {
        return new SkillUpgrade
        {
            Name = Name,
            CodeName = CodeName,
            Effects = Effects,
            PrerequisiteEffects = PrerequisiteEffects,
            Prerequisite = Prerequisite,
        };
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as SkillUpgrade);
    }

    public bool Equals(SkillUpgrade? other)
    {
        return other is not null &&
               Name == other.Name;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name);
    }

    public string GetCodeNameOrOverride()
    {
        return string.IsNullOrWhiteSpace(codeNameOverride) ? CodeName : codeNameOverride;
    }

    public string GetPrerequisiteOrOverride()
    {
        return string.IsNullOrWhiteSpace(prerequisiteOverride) ? Prerequisite : prerequisiteOverride;
    }

    public void OverrideCodeName(string nameOverride)
    {
        this.codeNameOverride = nameOverride;
    }

    public void OverridePrerequisite(string prerequisiteOverride)
    {
        this.prerequisiteOverride = prerequisiteOverride;
    }
}
