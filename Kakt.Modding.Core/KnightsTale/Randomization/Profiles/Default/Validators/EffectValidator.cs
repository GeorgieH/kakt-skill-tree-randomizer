using Kakt.Modding.Core.KnightsTale.Skills;

namespace Kakt.Modding.Core.KnightsTale.Randomization.Profiles.Default.Validators;

public class EffectValidator : ISkillSelector
{
    private readonly ISkillSelector next;

    public EffectValidator(ISkillSelector next)
    {
        this.next = next;
    }

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        var output = next.SelectSkill(input);

        var prerequisiteEffects = output.SkillInfo.PrerequisiteEffects;

        if (prerequisiteEffects != Effects.None
            && !input.Hero.CanCauseEffects(prerequisiteEffects))
        {
            throw new InvalidSkillSelectionException(output.SkillInfo);
        }

        return output;
    }
}
