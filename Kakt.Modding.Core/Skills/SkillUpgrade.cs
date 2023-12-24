namespace Kakt.Modding.Core.Skills;

public abstract class SkillUpgrade : IEquatable<SkillUpgrade?>
{
    public int Cost => 1;
    public Position2D IconPosition { get; set; }
    public virtual int LevelLimit { get; set; }
    public abstract string Name { get; }
    public abstract string Prerequisite { get; }
    public virtual int Tier { get; set; }
    public SkillUpgradeType Type => SkillUpgradeType.Mastery;

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
