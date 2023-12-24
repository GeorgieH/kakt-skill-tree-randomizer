using System.Reflection;

namespace Kakt.Modding.Core;

public static class AssemblyTypes
{
    public static readonly IEnumerable<Type> AllConcreteTypes = GetAllConcreteAssemblyTypes();

    private static Type[] GetAllConcreteAssemblyTypes()
    {
        return Assembly
            .GetExecutingAssembly()
            .GetTypes()
            .Where(t => !t.IsAbstract)
            .ToArray();
    }
}
