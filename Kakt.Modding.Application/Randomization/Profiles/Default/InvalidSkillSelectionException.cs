using Kakt.Modding.Domain.Skills;

namespace Kakt.Modding.Application.Randomization.Profiles.Default;

public class InvalidSkillSelectionException(Skill skill) : Exception
{
    public Skill Skill { get; } = skill;
}
