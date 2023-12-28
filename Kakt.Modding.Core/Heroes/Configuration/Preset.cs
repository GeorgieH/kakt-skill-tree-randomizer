namespace Kakt.Modding.Core.Heroes.Configuration;

public class Preset(string name)
{
    public List<Type> LearnedSkills { get; } = [];
    public string Name { get; } = name;
}
