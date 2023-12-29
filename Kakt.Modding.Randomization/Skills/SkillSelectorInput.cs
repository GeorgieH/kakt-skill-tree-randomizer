using Kakt.Modding.Core.Heroes;
using Kakt.Modding.Core.Skills;
using Kakt.Modding.Randomization.Skills.Default;

namespace Kakt.Modding.Randomization.Skills;

public class SkillSelectorInput(Hero hero, SkillTier skillTier, int skillNumber, DefaultRandomizationProfile profile)
{
    public Hero Hero { get; } = hero;
    public SkillTier SkillTier { get; } = skillTier;
    public int SkillNumber { get; } = skillNumber;
    public DefaultRandomizationProfile Profile { get; } = profile;
    public IEnumerable<Type> SkillTypes { get; set; } = [];
    public HashSet<Type> ExcludedSkillTypes { get; set; } = [];
}
