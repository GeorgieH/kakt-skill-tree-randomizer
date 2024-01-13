using Kakt.Modding.Domain;

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

        if (!input.Hero.CanCauseEffects(output.Skill.PrerequisiteEffects))
        {
            throw new InvalidSkillSelectionException(output.Skill);
        }

        return output;
    }
}
