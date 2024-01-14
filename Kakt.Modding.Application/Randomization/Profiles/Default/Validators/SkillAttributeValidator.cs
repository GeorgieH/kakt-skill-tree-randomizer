using Kakt.Modding.Domain;
using Kakt.Modding.Domain.Skills;

namespace Kakt.Modding.Application.Randomization.Profiles.Default.Validators;

public class SkillAttributeValidator : ISkillSelector
{
    private readonly ISkillSelector next;

    public SkillAttributeValidator(ISkillSelector next)
    {
        this.next = next;
    }

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        var output = this.next.SelectSkill(input);

        var prerequisiteAttributes = output.Skill.PrerequisiteAttributes;

        if (prerequisiteAttributes != SkillAttributes.None
            && !input.Hero.HasSkillAttributes(prerequisiteAttributes))
        {
            throw new InvalidSkillSelectionException(output.Skill);
        }

        return output;
    }
}
