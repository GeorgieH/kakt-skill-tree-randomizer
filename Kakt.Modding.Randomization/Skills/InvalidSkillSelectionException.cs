namespace Kakt.Modding.Randomization.Skills;

public class InvalidSkillSelectionException(Type skillType) : Exception
{
    public Type SkillType { get; } = skillType;
}
