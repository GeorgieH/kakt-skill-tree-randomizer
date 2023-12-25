using Kakt.Modding.Core.Skills;

namespace Kakt.Modding.Core.Heroes;

public abstract class Hero : IEquatable<Hero?>
{
    private readonly List<Skill> skills = [];

    public abstract string Name { get; }

    public IEnumerable<Skill> Skills => skills;

    public void AddSkill(Skill skill)
    {
        skills.Add(skill);
    }

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
