using System.Reflection;

namespace Kakt.Modding.Core.Heroes;

public static class Heroes
{
    private static readonly Type HeroType = typeof(Hero);

    private static readonly Type[] HeroTypes = GetAllHeroTypes();

    public static IEnumerable<Hero> GetAll()
    {
        var heroes = new HashSet<Hero>();

        foreach (var type in HeroTypes)
        {
            var instance = (Hero)Activator.CreateInstance(type)!;
            heroes.Add(instance);
        }

        return heroes;
    }

    private static Type[] GetAllHeroTypes()
    {
        return AssemblyTypes
            .AllConcreteTypes
            .Where(HeroType.IsAssignableFrom)
            .ToArray();
    }
}
