using System.Reflection;

namespace Kakt.Modding.Core.Skills.Cleave.Upgrades;

public abstract class CleaveUpgrade : SkillUpgrade
{
    private static readonly string prerequisite = typeof(Cleave).GetCustomAttribute<ConfigurationElementAttribute>()!.Name;

    public override string Prerequisite => prerequisite;
}
