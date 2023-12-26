using Kakt.Modding.Core.Heroes;
using Kakt.Modding.Core.Skills.Armourer;
using Kakt.Modding.Core.Skills.Ironclad;

namespace Kakt.Modding.Randomization.Skills.Default.Validators;

public class ArmourerValidator : ISkillSelector
{
    private readonly ISkillSelector next;

    public ArmourerValidator(ISkillSelector next)
    {
        this.next = next;
    }

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        var output = this.next.SelectSkill(input);

        if (output.SkillType == typeof(Armourer))
        {
            if (input.Hero is not Champion
                && input.Hero is not Defender
                && !input.Hero.SkillTree.Skills.Any(s => s is Ironclad))
            {
                throw new InvalidSkillSelectionException(output.SkillType);
            }
        }

        return output;
    }
}
