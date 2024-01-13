using Kakt.Modding.Domain;

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

        if (!input.Hero.HasSkillAttributes(output.Skill.PrerequisiteAttributes))
        {
            throw new InvalidSkillSelectionException(output.Skill);
        }

        return output;
    }
}
