using Kakt.Modding.Domain.Heroes;
using Kakt.Modding.Domain.Skills;

namespace Kakt.Modding.Application.Randomization.Profiles.Default.Filters;

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
            .Where(s => s!.Type == SkillType.Active);

        input.IncludedSkills = input.IncludedSkills
            .Where(s => s.Type == SkillType.Active)
            .Except(existingSkills)
            .Where(s => RespectsRandomizationProfile(input.Hero, s!, input.SkillNumber, input.Profile))!;

        return this.next.SelectSkill(input);
    }

    private static bool RespectsRandomizationProfile(
        Hero hero, Skill skill, int skillNumber, DefaultRandomizationProfile profile)
    {
        if (skillNumber == 2)
        {
            if (hero is Vanguard)
            {
                if (profile.Flags.VanguardsAlwaysGetTierOneMovementSkill)
                {
                    return VanguardMovementSkills.Contains(skill.Name);
                }

                if (profile.Flags.VanguardsAlwaysGetTierOneHide)
                {
                    return !skill.Name.Equals(SkillNames.Hide);
                }
            }
        }

        if (skillNumber == 3)
        {
            if (hero is Vanguard)
            {
                if (profile.Flags.VanguardsAlwaysGetTierOneTrapSkill)
                {
                    return skill.Attributes.HasFlag(SkillAttributes.Trap);
                }

                if (profile.Flags.VanguardsAlwaysGetTierOneHide)
                {
                    return !skill.Name.Equals(SkillNames.Hide);
                }
            }
        }

        if (skillNumber == 4)
        {
            if (hero is Vanguard && profile.Flags.VanguardsAlwaysGetTierOneHide)
            {
                return skill.Name.Equals(SkillNames.Hide);
            }
        }

        return true;
    }
}
