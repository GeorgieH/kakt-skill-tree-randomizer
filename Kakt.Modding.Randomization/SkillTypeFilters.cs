using Kakt.Modding.Core.Skills.Shoot;
using Kakt.Modding.Core.Skills.Strike;

namespace Kakt.Modding.Randomization;

public static class SkillTypeFilters
{
    private static readonly Type ShootType = typeof(Shoot);
    private static readonly Type StrikeType = typeof(Strike);

    public static IEnumerable<Type> ExcludeBasicAttackTypes(this IEnumerable<Type> source)
    {
        return source
            .ExcludeShoot()
            .ExcludeStrike();
    }

    public static IEnumerable<Type> ExcludeShoot(this IEnumerable<Type> source)
    {
        return source.Where(t => !ShootType.IsAssignableFrom(t));
    }

    public static IEnumerable<Type> ExcludeStrike(this IEnumerable<Type> source)
    {
        return source.Where(t => !StrikeType.IsAssignableFrom(t));
    }
}
