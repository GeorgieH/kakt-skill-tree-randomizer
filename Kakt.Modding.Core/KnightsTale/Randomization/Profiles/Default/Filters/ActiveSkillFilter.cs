using Kakt.Modding.Core.KnightsTale.Heroes;
using Kakt.Modding.Core.KnightsTale.Skills;

namespace Kakt.Modding.Core.KnightsTale.Randomization.Profiles.Default.Filters;

public class ActiveSkillFilter : ISkillSelector
{
    public static readonly HashSet<string> VanguardMovementSkills =
    [
        SkillNames.VanguardDash,
        SkillNames.Jump,
        SkillNames.Sprint,
    ];

    private readonly ISkillSelector next;

    public ActiveSkillFilter(ISkillSelector next)
    {
        this.next = next;
    }

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        var existingSkills = input.Hero.SkillTree.Skills
            .Where(s => s.Type == SkillType.Active)
            .Select(s => s.Info);

        input.IncludedSkillInfos = input.IncludedSkillInfos
            .Where(s => s.Type == SkillType.Active)
            .Except(existingSkills)
            .Where(s => RespectsRandomizationProfile(s, input))
            .Where(s => RespectsHeroRestrictions(s, input));

        return next.SelectSkill(input);
    }

    private static bool RespectsRandomizationProfile(SkillInfo skillInfo, SkillSelectorInput input)
    {
        var hero = input.Hero;
        var profile = input.Profile;
        var skillNumber = input.SkillNumber;

        if (hero is Vanguard)
        {
            if (profile.Flags.VanguardsAlwaysGetTierOneMovementSkill)
            {
                if (skillNumber == 2)
                {
                    return VanguardMovementSkills.Contains(skillInfo.Name);
                }

                if (skillNumber == 3 || skillNumber == 4)
                {
                    return !VanguardMovementSkills.Contains(skillInfo.Name);
                }
            }

            if (profile.Flags.VanguardsAlwaysGetTierOneTrapSkill)
            {
                if (skillNumber == 2 || skillNumber == 4)
                {
                    return !skillInfo.Attributes.HasFlag(SkillAttributes.Trap);
                }

                if (skillNumber == 3)
                {
                    return skillInfo.Attributes.HasFlag(SkillAttributes.Trap);
                }
            }

            if (profile.Flags.VanguardsAlwaysGetTierOneHide)
            {
                if (skillNumber == 2 || skillNumber == 3)
                {
                    return !skillInfo.Name.Equals(SkillNames.Hide);
                }

                if (skillNumber == 4)
                {
                    return skillInfo.Name.Equals(SkillNames.Hide);
                }
            }
        }

        return true;
    }

    private static bool RespectsHeroRestrictions(SkillInfo skillInfo, SkillSelectorInput input)
    {
        var hero = input.Hero;
        var skillTier = input.SkillTier;

        if (hero is SirLanval
            && skillTier == SkillTier.One
            && skillInfo.Name == SkillNames.Preparedness)
        {
            return false;
        }

        return true;
    }
}
