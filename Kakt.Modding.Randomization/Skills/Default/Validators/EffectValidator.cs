using Kakt.Modding.Core;
using Kakt.Modding.Core.Skills;
using System.Reflection;

namespace Kakt.Modding.Randomization.Skills.Default.Validators;

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
        var attr = output.SkillType.GetCustomAttribute<RequiresEffects>();

        if (attr is null)
        {
            return output;
        }

        if (!input.Hero.CanCauseEffects(attr.Effects))
        {
            throw new InvalidSkillSelectionException(output.SkillType);
        }

        return output;
    }
}
