using Kakt.Modding.Core.Heroes;
using Kakt.Modding.Core.Skills;
using System.Reflection;

namespace Kakt.Modding.Core;

public static class Extensions
{
    public static bool CanCauseEffects(this Hero hero, Effects effects)
    {
        return hero.SkillTree.Skills
            .Any(s => s.CanCauseEffects(effects));
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
        var attr = obj.GetType().GetCustomAttribute<CausesEffects>();

        if (attr is null)
        {
            return false;
        }

        return effects
            .GetFlags()
            .Any(e => attr.Effects.HasFlag(e));
    }
}
