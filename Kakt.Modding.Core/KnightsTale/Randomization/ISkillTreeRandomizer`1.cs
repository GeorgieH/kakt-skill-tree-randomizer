using Kakt.Modding.Core.KnightsTale.Heroes;

namespace Kakt.Modding.Core.KnightsTale.Randomization;

public interface ISkillTreeRandomizer<T>
{
    IEnumerable<Hero> Generate(T profile);
}
