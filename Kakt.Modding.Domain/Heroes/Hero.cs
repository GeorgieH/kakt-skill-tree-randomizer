using Kakt.Modding.Domain.Skills;

namespace Kakt.Modding.Domain.Heroes;

public abstract class Hero : IEquatable<Hero?>
{
    public abstract string Name { get; }

    public SkillTree SkillTree { get; } = new();
    public HeroTraits Traits { get; set; }
    public List<HeroPreset> Presets { get; } = new();

    public override bool Equals(object? obj)
    {
        return Equals(obj as Hero);
    }

    public bool Equals(Hero? other)
    {
        return other is not null && Name == other.Name;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name);
    }
}
