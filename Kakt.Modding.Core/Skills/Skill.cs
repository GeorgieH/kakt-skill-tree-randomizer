namespace Kakt.Modding.Core.Skills;

public abstract class Skill : ISkill, IEquatable<Skill?>
{
    private string? nameOverride;

    public int Cost { get; set; } = SkillCosts.Two;
    public string? IconName { get; set; }
    public Position2D IconPosition { get; set; }
    public abstract string Name { get; }
    public bool Starter { get; set; }
    public SkillTier Tier { get; set; }
    public abstract SkillType Type { get; }
    public List<SkillUpgrade> Upgrades { get; } = [];

    public string GetNameOrOverride()
    {
        return string.IsNullOrWhiteSpace(nameOverride) ? Name : nameOverride;
    }

    public void OverrideName(string nameOverride)
    {
        this.nameOverride = nameOverride;
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as Skill);
    }

    public bool Equals(Skill? other)
    {
        return other is not null && Name == other.Name;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name);
    }
}
