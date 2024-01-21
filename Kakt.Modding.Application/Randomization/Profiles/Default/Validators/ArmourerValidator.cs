using Kakt.Modding.Domain.Heroes;

namespace Kakt.Modding.Application.Randomization.Profiles.Default.Validators;

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

        if (output.Skill.Name.Equals(SkillNames.Armourer))
        {
            if (input.Hero is not Champion
                && input.Hero is not Defender
                && !input.Hero.SkillTree.Skills.Any(s => SkillNames.Ironclad.Equals(s!.Name)))
            {
                throw new InvalidSkillSelectionException(output.Skill);
            }
        }

        return output;
    }
}
