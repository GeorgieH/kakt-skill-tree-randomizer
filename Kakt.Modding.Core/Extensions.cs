using Kakt.Modding.Core.Heroes;
using Kakt.Modding.Core.Skills;
using System.Reflection;

namespace Kakt.Modding.Core;

public static class Extensions
{
    public static string GetConfigurationElementName(this Skill skill)
    {
        var skillType = skill.GetType();
        var attr = skillType.GetCustomAttribute<ConfigurationElementAttribute>(true);

        if (attr is null)
        {
            return skillType.Name;
        }

        return attr.Name;
    }

    public static bool CanCauseEffects(this Hero hero, Effects effects)
    {
        return hero.SkillTree.Skills
            .Where(s => s is not null)
            .Any(s => s!.CanCauseEffects(effects));
    }

    public static bool CanCauseEffects(this Skill skill, Effects effects)
    {
        var result = CanCauseEffects(skill as object, effects);

        if (result)
        {
            return true;
        }

        return skill.Upgrades
            .Any(s => s.CanCauseEffects(effects));

    }

    public static bool CanCauseEffects(this SkillUpgrade skillUpgrade, Effects effects)
    {
        return CanCauseEffects(skillUpgrade as object, effects);
    }

    private static bool CanCauseEffects(object obj, Effects effects)
    {
        var attr = obj.GetType().GetCustomAttribute<CausesEffects>(true);

        if (attr is null)
        {
            return false;
        }

        return effects
            .GetFlags()
            .Any(e => attr.Effects.HasFlag(e));
    }

    public static bool HasSkillAttributes(this Hero hero, SkillAttributes skillAttributes)
    {
        return hero.SkillTree.Skills
            .Where(s => s is not null)
            .Any(s => s!.HasSkillAttributes(skillAttributes));
    }

    public static bool HasSkillAttributes(this Skill skill, SkillAttributes skillAttributes)
    {
        var attr = skill.GetType().GetCustomAttribute<SkillAttributesAttribute>(true);

        if (attr is null)
        {
            return false;
        }

        return skillAttributes
            .GetFlags()
            .Any(s => attr.SkillAttributes.HasFlag(s));
    }
}
