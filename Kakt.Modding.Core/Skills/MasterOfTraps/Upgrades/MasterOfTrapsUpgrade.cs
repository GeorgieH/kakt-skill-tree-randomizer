using System.Reflection;

namespace Kakt.Modding.Core.Skills.MasterOfTraps.Upgrades;

public abstract class MasterOfTrapsUpgrade : SkillUpgrade
{
    private static readonly string prerequisite = typeof(MasterOfTraps).GetCustomAttribute<ConfigurationElementAttribute>()!.Name;

    public override string Prerequisite => prerequisite;
}
