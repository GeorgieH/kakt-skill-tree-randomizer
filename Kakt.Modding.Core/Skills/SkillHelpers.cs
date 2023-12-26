using System.Reflection;

namespace Kakt.Modding.Core.Skills;

public static class SkillHelpers
{
    private static readonly Dictionary<Type, IEnumerable<SkillUpgrade>> SkillUpgradeCache = [];

    public static IEnumerable<SkillUpgrade> GetSkillUpgrades(Type skillType)
    {
        if (SkillUpgradeCache.TryGetValue(skillType, out var cachedSkillUpgrades))
        {
            return cachedSkillUpgrades;
        }

        var skillUpgradeType = typeof(SkillUpgrade<>).MakeGenericType(skillType);

        var skillUpgradeTypes = Assembly
            .GetExecutingAssembly()
            .GetTypes()
            .Where(skillUpgradeType.IsAssignableFrom);

        var skillUpgrades = new List<SkillUpgrade>();

        foreach (var type in skillUpgradeTypes)
        {
            var skillUpgrade = (SkillUpgrade)Activator.CreateInstance(type)!;
            skillUpgrades.Add(skillUpgrade);
        }

        SkillUpgradeCache.Add(skillType, skillUpgrades);

        return skillUpgrades;
    }
}
