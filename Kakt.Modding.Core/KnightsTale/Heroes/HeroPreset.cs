using Kakt.Modding.Core.KnightsTale.Skills;

namespace Kakt.Modding.Core.KnightsTale.Heroes;

public class HeroPreset
{
    public HeroPreset(string name)
    {
        Name = name;
    }

    public List<ISkill> LearnedSkills { get; } = [];
    public string Name { get; }
}
