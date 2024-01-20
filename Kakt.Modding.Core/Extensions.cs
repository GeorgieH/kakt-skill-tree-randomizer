using Kakt.Modding.Core.KnightsTale.Heroes;
using Kakt.Modding.Core.KnightsTale.Skills;

namespace Kakt.Modding.Core;

public static class Extensions
{
    public static bool CanCauseEffects(this Hero hero, Effects effects)
    {
        return hero.SkillTree.Skills
            .Any(s => s!.CanCauseEffects(effects));
    }

    public static bool CanCauseEffects(this Skill skill, Effects effects)
    {
        var result = CanCauseEffects(skill.Effects, effects);

        if (result)
        {
            return true;
        }

        return skill.Upgrades
            .Any(s => s.CanCauseEffects(effects));
    }

    public static bool CanCauseEffects(this SkillUpgrade skillUpgrade, Effects effects)
    {
        return CanCauseEffects(skillUpgrade.Effects, effects);
    }

    private static bool CanCauseEffects(Effects source, Effects target)
    {
        return target
            .GetFlags()
            .Any(e => source.HasFlag(e));
    }

    public static bool HasAnySkillWithAnySkillAttribute(this Hero hero, SkillAttributes skillAttributes)
    {
        return hero.SkillTree.Skills
            .Any(s => s!.HasAnySkillAttribute(skillAttributes));
    }

    public static bool HasAnySkillWithAllSkillAttributes(this Hero hero, SkillAttributes skillAttributes)
    {
        return hero.SkillTree.Skills
            .Any(s => s!.HasAllSkillAttributes(skillAttributes));
    }

    public static bool HasAnySkillAttribute(this Skill skill, SkillAttributes skillAttributes)
    {
        return skillAttributes
            .GetFlags()
            .Any(s => skill.Attributes.HasFlag(s));
    }

    public static bool HasAllSkillAttributes(this Skill skill, SkillAttributes skillAttributes)
    {
        return skillAttributes
            .GetFlags()
            .All(s => skill.Attributes.HasFlag(s));
    }
}
