using System.Reflection;

namespace Kakt.Modding.Core.Heroes;

public static class Heroes
{
    private static readonly Type HeroType = typeof(Hero);

    public static IEnumerable<Hero> GetAll()
    {
        var types = Assembly
            .GetExecutingAssembly()
            .GetTypes()
            .Where(t => t != HeroType)
            .Where(HeroType.IsAssignableFrom);

        var heroes = new HashSet<Hero>();

        foreach (var type in types)
        {
            var instance = (Hero)Activator.CreateInstance(type)!;
            heroes.Add(instance);
        }

        return heroes;
    }
}
