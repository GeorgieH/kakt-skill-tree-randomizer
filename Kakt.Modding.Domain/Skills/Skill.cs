
namespace Kakt.Modding.Domain.Skills;

public class Skill : ISkill, IEquatable<Skill?>
{
    private string? nameOverride;

    public string Name { get; set; }
    public string CodeName { get; set; }
    public string? ConfigurationName { get; set; }
    public string? IconName { get; set; }
    public SkillType Type { get; set; }
    public bool Upgradable { get; set; }
    public SkillAttributes Attributes { get; set; }
    public SkillAttributes PrerequisiteAttributes { get; set; }
    public Effects Effects { get; set; }
    public Effects PrerequisiteEffects { get; set; }
    public bool Starter { get; set; }
    public SkillTier Tier { get; set; }
    public Position2D IconPosition { get; set; }
    public int Cost { get; set; } = SkillCosts.Two;
    public List<SkillUpgrade> Upgrades { get; } = [];

    public Skill Copy()
    {
        return new Skill
        {
            Name = Name,
            CodeName = CodeName,
            ConfigurationName = ConfigurationName,
            IconName = IconName,
            Type = Type,
            Upgradable = Upgradable,
            Attributes = Attributes,
            PrerequisiteAttributes = PrerequisiteAttributes,
            Effects = Effects,
            PrerequisiteEffects = PrerequisiteEffects
        };
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as Skill);
    }

    public bool Equals(Skill? other)
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
