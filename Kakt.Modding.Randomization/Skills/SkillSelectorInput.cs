using Kakt.Modding.Core.Heroes;
using Kakt.Modding.Core.Skills;

namespace Kakt.Modding.Randomization.Skills;

public class SkillSelectorInput(Hero hero, SkillTier skillTier)
{
    public Hero Hero { get; } = hero;
    public SkillTier SkillTier { get; } = skillTier;
    public IEnumerable<Type> SkillTypes { get; set; } = [];
    public HashSet<Type> ExcludedSkillTypes { get; set; } = [];
}
