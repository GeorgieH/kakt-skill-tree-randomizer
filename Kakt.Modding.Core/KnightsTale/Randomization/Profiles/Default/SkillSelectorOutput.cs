using Kakt.Modding.Core.KnightsTale.Skills;

namespace Kakt.Modding.Core.KnightsTale.Randomization.Profiles.Default;

public class SkillSelectorOutput(SkillInfo skillInfo)
{
    public SkillInfo SkillInfo { get; } = skillInfo;
}
