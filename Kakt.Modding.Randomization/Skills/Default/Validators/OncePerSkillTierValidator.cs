using Kakt.Modding.Core.Skills.EnchantedWeapon;
using Kakt.Modding.Core.Skills.Robust;
using Kakt.Modding.Core.Skills.Scout.Marksman;
using Kakt.Modding.Core.Skills.Scout.Vanguard;
using Kakt.Modding.Core.Skills.Strength;

namespace Kakt.Modding.Randomization.Skills.Default.Validators;

public class OncePerSkillTierValidator : ISkillSelector
{
    private static readonly HashSet<Type> Types =
    [
        typeof(EnchantedWeapon),
        typeof(Robust),
        typeof(MarksmanScout),
        typeof(VanguardScout),
        typeof(Strength)
    ];

    private readonly ISkillSelector next;

    public OncePerSkillTierValidator(ISkillSelector next)
    {
        this.next = next;
    }

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        var output = this.next.SelectSkill(input);

        if (!Types.Contains(output.SkillType))
        {
            return output;
        }

        var exists = input.Hero.SkillTree.Skills
            .Where(s => s is not null)
            .Where(s => s!.Tier == input.SkillTier)
            .Any(s => s!.GetType() == output.SkillType);

        if (exists)
        {
            throw new InvalidSkillSelectionException(output.SkillType);
        }

        return output;
    }
}
