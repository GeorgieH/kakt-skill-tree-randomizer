using Kakt.Modding.Domain.Skills;

namespace Kakt.Modding.Domain.Heroes;

public class HeroPreset
{
    public HeroPreset(string name)
    {
        Name = name;
    }

    public List<ISkill> LearnedSkills { get; } = [];
    public string Name { get; }
}
