using System.Reflection;

namespace Kakt.Modding.Core.Skills;

public static class Skills
{
    private static readonly IEnumerable<Type> SkillTypes = Assembly
        .GetExecutingAssembly()
        .GetTypes()
        .Where(typeof(Skill).IsAssignableFrom);

    public static IEnumerable<Type> GetAllTypes()
    {
        return SkillTypes;
    }
}
