using Kakt.Modding.Domain.Skills;

namespace Kakt.Modding.Application.Randomization.Profiles.Default;

public class SkillSelectorOutput(Skill skill)
{
    public Skill Skill { get; } = skill;
}
