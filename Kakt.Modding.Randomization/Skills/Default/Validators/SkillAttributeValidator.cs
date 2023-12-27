using Kakt.Modding.Core.Skills;
using Kakt.Modding.Core;
using System.Reflection;

namespace Kakt.Modding.Randomization.Skills.Default.Validators;

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
        var attr = output.SkillType.GetCustomAttribute<RequiresSkillAttributesAttribute>();

        if (attr is null)
        {
            return output;
        }

        if (!input.Hero.HasSkillAttributes(attr.SkillAttributes))
        {
            throw new InvalidSkillSelectionException(output.SkillType);
        }

        return output;
    }
}
