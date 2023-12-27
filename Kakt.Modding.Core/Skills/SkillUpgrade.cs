﻿namespace Kakt.Modding.Core.Skills;

public abstract class SkillUpgrade : ISkill, IEquatable<SkillUpgrade?>
{
    private string? nameOverride;
    private string? prerequisiteOverride;

    public int Cost => 1;
    public string? IconName { get; set; }
    public Position2D IconPosition { get; set; }
    public int LevelLimit { get; set; }
    public abstract string Name { get; }
    public abstract string Prerequisite { get; }
    public SkillTier Tier { get; set; }
    public SkillUpgradeType Type => SkillUpgradeType.Mastery;

    public string GetNameOrOverride()
    {
        return string.IsNullOrWhiteSpace(nameOverride) ? Name : nameOverride;
    }

    public string GetPrerequisiteOrOverride()
    {
        return string.IsNullOrWhiteSpace(prerequisiteOverride) ? Prerequisite : prerequisiteOverride;
    }

    public void OverrideName(string nameOverride)
    {
        this.nameOverride = nameOverride;
    }

    public void OverridePrerequisite(string prerequisiteOverride)
    {
        this.prerequisiteOverride = prerequisiteOverride;
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as SkillUpgrade);
    }

    public bool Equals(SkillUpgrade? other)
    {
        return other is not null && Name == other.Name;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name);
    }
}
