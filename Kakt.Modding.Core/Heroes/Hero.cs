using Kakt.Modding.Core.Skills;

namespace Kakt.Modding.Core.Heroes;

public abstract class Hero : IEquatable<Hero?>
{
    private readonly HashSet<Skill> skills = [];

    public abstract HeroClass Class { get; }

    public abstract string Name { get; }

    public IEnumerable<Skill> Skills => skills;

    public void AddSkill(Skill skill)
    {
        var result = skills.Add(skill);

        if (!result)
        {
            throw new ArgumentException($"Skill has already been added ({skill.Name})");
        }
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
