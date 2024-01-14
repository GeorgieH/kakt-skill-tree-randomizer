namespace Kakt.Modding.Application.Randomization.Profiles.Default.Validators;

public class OncePerSkillTreeValidator : ISkillSelector
{
    private readonly ISkillSelector next;

    public OncePerSkillTreeValidator(ISkillSelector next)
    {
        this.next = next;
    }

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        var output = this.next.SelectSkill(input);

        if (!input.Profile.Rules.OncePerSkillTree.Contains(output.Skill.Name))
        {
            return output;
        }

        var exists = input.Hero.SkillTree.Skills.Any(output.Skill.Equals);

        if (exists)
        {
            throw new InvalidSkillSelectionException(output.Skill);
        }

        return output;
    }
}
