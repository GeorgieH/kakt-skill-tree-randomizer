using Kakt.Modding.Core.KnightsTale.Skills;

namespace Kakt.Modding.Core.KnightsTale.Randomization.Profiles.Default;

public class InvalidSkillSelectionException(SkillInfo skillInfo) : Exception
{
    public SkillInfo SkillInfo { get; } = skillInfo;
}
