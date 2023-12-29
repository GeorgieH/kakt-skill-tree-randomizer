using Kakt.Modding.Core.Heroes;
using Kakt.Modding.Core.Skills;
using Kakt.Modding.Core.Skills.Dash;
using Kakt.Modding.Core.Skills.Hide;
using Kakt.Modding.Core.Skills.Jump;
using Kakt.Modding.Core.Skills.Sprint;

namespace Kakt.Modding.Randomization.Skills.Default.Filters;

public class ActiveSkillFilter : ISkillSelector
{
    public static readonly List<Type> VanguardMovementSkills =
    [
        typeof(VanguardDash),
        typeof(Jump),
        typeof(Sprint),
    ];

    private readonly ISkillSelector next;

    public ActiveSkillFilter(ISkillSelector next)
    {
        this.next = next;
    }

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        var existingSkillTypes = input.Hero.SkillTree.Skills
            .Where(s => s is not null)
            .Where(s => s is ActiveSkill)
            .Select(s => s!.GetType());

        input.SkillTypes = input.SkillTypes
            .Where(typeof(ActiveSkill).IsAssignableFrom)
            .Except(existingSkillTypes)
            .Where(s => RespectsRandomizationProfile(input.Hero, s, input.SkillNumber, input.Profile));

        return this.next.SelectSkill(input);
    }

    private static bool RespectsRandomizationProfile(
        Hero hero, Type skillType, int skillNumber, DefaultRandomizationProfile profile)
    {
        if (skillNumber == 2)
        {
            if (hero is Vanguard)
            {
                if (profile.Flags.VanguardsAlwaysGetTierOneHide)
                {
                    return skillType != typeof(Hide);
                }

                if (profile.Flags.VanguardsAlwaysGetTierOneMovementSkill)
                {
                    return VanguardMovementSkills.Contains(skillType);
                }
            }
        }

        if (skillNumber == 3)
        {
            if (hero is Vanguard && profile.Flags.VanguardsAlwaysGetTierOneHide)
            {
                return skillType != typeof(Hide);
            }
        }

        if (skillNumber == 4)
        {
            if (hero is Vanguard && profile.Flags.VanguardsAlwaysGetTierOneHide)
            {
                return skillType == typeof(Hide);
            }
        }

        return true;
    }
}
