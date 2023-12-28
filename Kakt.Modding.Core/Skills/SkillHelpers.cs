using System.Reflection;

namespace Kakt.Modding.Core.Skills;

public static class SkillHelpers
{
    private static readonly Dictionary<Type, IEnumerable<Type>> SkillUpgradeTypeCache = [];

    public static IEnumerable<SkillUpgrade> GetSkillUpgrades(Type skillType)
    {
        if (!SkillUpgradeTypeCache.TryGetValue(skillType, out var skillUpgradeTypes))
        {
            var genericTypeArgument = skillType;
            var attr = skillType.GetCustomAttribute<SkillUpgradeTypeAttribute>(true);

            if (attr is not null)
            {
                genericTypeArgument = attr.SkillType;
            }

            var skillUpgradeType = typeof(SkillUpgrade<>).MakeGenericType(genericTypeArgument);

            skillUpgradeTypes = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(skillUpgradeType.IsAssignableFrom);

            SkillUpgradeTypeCache.Add(skillType, skillUpgradeTypes);
        }

        var skillUpgrades = new List<SkillUpgrade>();

        foreach (var type in skillUpgradeTypes)
        {
            var skillUpgrade = (SkillUpgrade)Activator.CreateInstance(type)!;
            skillUpgrades.Add(skillUpgrade);
        }

        return skillUpgrades;
    }
}
