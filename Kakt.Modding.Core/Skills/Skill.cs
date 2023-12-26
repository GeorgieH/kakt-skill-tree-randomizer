﻿namespace Kakt.Modding.Core.Skills;

public abstract class Skill : IEquatable<Skill?>
{
    private readonly List<SkillUpgrade> upgrades = [];

    public int Cost { get; set; } = SkillCosts.Two;
    public string? IconName { get; set; }
    public Position2D IconPosition { get; set; }
    public abstract string Name { get; }
    public bool Starter { get; set; }
    public SkillTier Tier { get; set; }
    public abstract SkillType Type { get; }
    public IEnumerable<SkillUpgrade> Upgrades => upgrades;

    public void AddUpgrade(SkillUpgrade skillUpgrade)
    {
        upgrades.Add(skillUpgrade);
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
