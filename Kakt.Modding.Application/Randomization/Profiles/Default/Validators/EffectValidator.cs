using Kakt.Modding.Domain;
using Kakt.Modding.Domain.Skills;

namespace Kakt.Modding.Application.Randomization.Profiles.Default.Validators;

public class EffectValidator : ISkillSelector
{
    private readonly ISkillSelector next;

    public EffectValidator(ISkillSelector next)
    {
        this.next = next;
    }

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        var output = this.next.SelectSkill(input);

        var prerequisiteEffects = output.Skill.PrerequisiteEffects;

        if (prerequisiteEffects != Effects.None
            && !input.Hero.CanCauseEffects(prerequisiteEffects))
        {
            throw new InvalidSkillSelectionException(output.Skill);
        }

        return output;
    }
}
