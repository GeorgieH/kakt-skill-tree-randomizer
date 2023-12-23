namespace Kakt.Modding.Core.Skills;

public abstract class Skill : IEquatable<Skill?>
{
    private const int MaxUpgradeCount = 4;

    private readonly HashSet<SkillUpgrade> upgrades = [];

    public virtual int Cost { get; set; }
    public Position2D IconPosition { get; set; }
    public abstract string Name { get; }
    public virtual bool Starter { get; set; }
    public virtual SkillTier Tier { get; set; }
    public abstract SkillType Type { get; }
    public IEnumerable<SkillUpgrade> Upgrades => upgrades;

    public void AddUpgrade(SkillUpgrade skillUpgrade)
    {
        if (upgrades.Count == MaxUpgradeCount)
        {
            throw new ArgumentException($"Skills can only have a maximum of {MaxUpgradeCount} upgrades");
        }

        var result = upgrades.Add(skillUpgrade);

        if (!result)
        {
            throw new ArgumentException($"Skill upgrade has already been added ({skillUpgrade.Name})");
        }
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
