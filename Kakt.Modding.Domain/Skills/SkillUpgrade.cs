
namespace Kakt.Modding.Domain.Skills;

public class SkillUpgrade : ISkill, IEquatable<SkillUpgrade?>
{
    private string? nameOverride;

    public string Name { get; set; }
    public string CodeName { get; set; }
    public string ConfigurationName { get; set; }
    public string? IconName { get; set; }
    public Effects Effects { get; set; }
    public SkillTier Tier { get; set; }
    public SkillUpgradeType Type => SkillUpgradeType.Mastery;

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

    public string GetNameOrOverride()
    {
        return string.IsNullOrWhiteSpace(nameOverride) ? Name : nameOverride;
    }

    public void OverrideName(string nameOverride)
    {
        this.nameOverride = nameOverride;
    }
}
