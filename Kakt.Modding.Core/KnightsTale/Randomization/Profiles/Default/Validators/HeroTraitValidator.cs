using Kakt.Modding.Core.KnightsTale.Heroes;

namespace Kakt.Modding.Core.KnightsTale.Randomization.Profiles.Default.Validators;

public class HeroTraitValidator : ISkillSelector
{
    private readonly ISkillSelector next;

    public HeroTraitValidator(ISkillSelector next)
    {
        this.next = next;
    }

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        var output = next.SelectSkill(input);

        if (input.Hero.Traits.HasFlag(HeroTraits.Sober))
        {
            var name = output.SkillInfo.Name;

            if (name.Equals(SkillNames.MasterAlchemist)
                || name.Equals(SkillNames.MasterOfPotions))
            {
                throw new InvalidSkillSelectionException(output.SkillInfo);
            }
        }

        return output;
    }
}
