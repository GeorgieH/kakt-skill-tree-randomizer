using Kakt.Modding.Core.Heroes;

namespace Kakt.Modding.Randomization.Skills;

public class SkillSelectorInput(Hero hero, IEnumerable<Type> skillTypes)
{
    public Hero Hero { get; } = hero;
    public IEnumerable<Type> SkillTypes { get; set; } = skillTypes;
}
