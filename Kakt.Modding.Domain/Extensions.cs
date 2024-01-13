using Kakt.Modding.Domain.Heroes;
using Kakt.Modding.Domain.Skills;

namespace Kakt.Modding.Domain;

public static class Extensions
{
    public static bool CanCauseEffects(this Hero hero, Effects effects)
    {
        return hero.SkillTree.Skills
            .Where(s => s is not null)
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

    public static bool HasSkillAttributes(this Hero hero, SkillAttributes skillAttributes)
    {
        return hero.SkillTree.Skills
            .Where(s => s is not null)
            .Any(s => s!.HasSkillAttributes(skillAttributes));
    }

    public static bool HasSkillAttributes(this Skill skill, SkillAttributes skillAttributes)
    {
        return skillAttributes
            .GetFlags()
            .Any(s => skill.Attributes.HasFlag(s));
    }
}
