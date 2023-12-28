using Kakt.Modding.Core.Skills;

namespace Kakt.Modding.Core.Heroes.Configuration;

public class Preset(string name)
{
    public List<ISkill> LearnedSkills { get; } = [];
    public string Name { get; } = name;
}
