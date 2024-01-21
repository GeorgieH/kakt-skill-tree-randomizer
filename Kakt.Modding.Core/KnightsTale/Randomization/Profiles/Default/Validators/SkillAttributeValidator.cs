using Kakt.Modding.Core.KnightsTale.Skills;

namespace Kakt.Modding.Core.KnightsTale.Randomization.Profiles.Default.Validators;

public class SkillAttributeValidator : ISkillSelector
{
    private readonly ISkillSelector next;

    public SkillAttributeValidator(ISkillSelector next)
    {
        this.next = next;
    }

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        var output = next.SelectSkill(input);

        var prerequisiteAttributes = output.SkillInfo.PrerequisiteAttributes;

        if (prerequisiteAttributes != SkillAttributes.None)
        {
            bool valid;

            if (output.SkillInfo.PrerequisiteAttributesCheckType == PrerequisiteCheckType.All)
            {
                valid = input.Hero.HasAnySkillWithAllSkillAttributes(prerequisiteAttributes);
            }
            else
            {
                valid = input.Hero.HasAnySkillWithAnySkillAttribute(prerequisiteAttributes);
            }

            if (!valid)
            {
                throw new InvalidSkillSelectionException(output.SkillInfo);
            }
        }

        return output;
    }
}
