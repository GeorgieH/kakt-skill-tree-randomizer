using Kakt.Modding.Core.KnightsTale.Heroes;

namespace Kakt.Modding.Core.KnightsTale.Randomization.Profiles.Default.Validators;

public class ArmourerValidator : ISkillSelector
{
    private readonly ISkillSelector next;

    public ArmourerValidator(ISkillSelector next)
    {
        this.next = next;
    }

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        var output = next.SelectSkill(input);

        if (output.SkillInfo.Name.Equals(SkillNames.Armourer))
        {
            if (input.Hero is not Champion
                && input.Hero is not Defender
                && !input.Hero.SkillTree.Skills.Select(s => s.Name).Any(SkillNames.Ironclad.Equals))
            {
                throw new InvalidSkillSelectionException(output.SkillInfo);
            }
        }

        return output;
    }
}
