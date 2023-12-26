using Kakt.Modding.Core.Heroes;

namespace Kakt.Modding.Randomization.Skills;

public class SkillSelectorInput(Hero hero)
{
    public Hero Hero { get; } = hero;
    public IEnumerable<Type> SkillTypes { get; set; } = [];
    public IEnumerable<Type> ExcludedSkillTypes { get; set; } = [];
}
