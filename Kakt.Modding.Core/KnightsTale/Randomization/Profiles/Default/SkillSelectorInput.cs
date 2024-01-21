using Kakt.Modding.Core.KnightsTale.Heroes;
using Kakt.Modding.Core.KnightsTale.Skills;

namespace Kakt.Modding.Core.KnightsTale.Randomization.Profiles.Default;

public class SkillSelectorInput(
    Hero hero,
    SkillTier skillTier,
    int skillNumber,
    DefaultRandomizationProfile profile)
{
    public Hero Hero { get; } = hero;
    public SkillTier SkillTier { get; } = skillTier;
    public int SkillNumber { get; } = skillNumber;
    public DefaultRandomizationProfile Profile { get; } = profile;
    public IEnumerable<SkillInfo> IncludedSkillInfos { get; set; } = [];
    public HashSet<SkillInfo> ExcludedSkillInfos { get; set; } = [];
}
