using Kakt.Modding.Core.Heroes;
using Kakt.Modding.Core.Skills;
using Kakt.Modding.Core.Skills.BearTrap;
using Kakt.Modding.Core.Skills.BleedingStrike;
using Kakt.Modding.Core.Skills.Cleave;
using Kakt.Modding.Core.Skills.Dash;
using Kakt.Modding.Core.Skills.FireArrow;
using Kakt.Modding.Core.Skills.Guard;
using Kakt.Modding.Core.Skills.Hide;
using Kakt.Modding.Core.Skills.Jump;
using Kakt.Modding.Core.Skills.MindFog;
using Kakt.Modding.Core.Skills.PowerAttack;
using Kakt.Modding.Core.Skills.SlowingHex;
using Kakt.Modding.Core.Skills.Sprint;
using Kakt.Modding.Core.Skills.Teleport;

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
            .Where(s => IsValidStarterSkill(input.Hero, s, input.SkillNumber))
            .Where(s => IsValidMerlinSkill(input.Hero, s, input.SkillNumber));

        return this.next.SelectSkill(input);
    }

    private static bool IsValidStarterSkill(Hero hero, Type skillType, int skillNumber)
    {
        if (skillNumber != 3)
        {
            return true;
        }

        if (hero is LadyDindraine)
        {
            return skillType == typeof(FireArrow);
        }

        if (hero is Merlin)
        {
            return skillType == typeof(Teleport);
        }

        if (hero is RedKnight)
        {
            return skillType == typeof(BleedingStrike);
        }

        if (hero is SirBalan)
        {
            return skillType == typeof(PowerAttack);
        }

        if (hero is SirBalin)
        {
            return skillType == typeof(BearTrap);
        }

        if (hero is SirDagonet || hero is SirEctor)
        {
            return skillType == typeof(SlowingHex);
        }

        if (hero is SirKay)
        {
            return skillType == typeof(Cleave);
        }

        if (hero is SirPelleas)
        {
            return skillType == typeof(Guard);
        }

        return true;
    }

    private static bool IsValidMerlinSkill(Hero hero, Type skillType, int skillNumber)
    {
        if (hero is Merlin && skillNumber == 2)
        {
            return skillType == typeof(MindFog);
        }

        return true;
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
