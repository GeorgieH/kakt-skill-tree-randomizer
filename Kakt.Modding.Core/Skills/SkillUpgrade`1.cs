using System.Reflection;

namespace Kakt.Modding.Core.Skills;

public abstract class SkillUpgrade<T> : SkillUpgrade where T : Skill
{
    private readonly string prerequisite;

    protected SkillUpgrade()
    {
        var attr = typeof(T).GetCustomAttribute<ConfigurationElementAttribute>(true);
        prerequisite = attr is null ? typeof(T).Name : attr.Name;
    }

    public override string Prerequisite => prerequisite;
}
