namespace Kakt.Modding.Randomization.Skills;

public class InvalidSkillTypeException(string skill) : Exception
{
    public string Skill { get; } = skill;
}
