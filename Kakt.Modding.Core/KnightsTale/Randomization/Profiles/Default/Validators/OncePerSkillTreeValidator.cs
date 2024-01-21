namespace Kakt.Modding.Core.KnightsTale.Randomization.Profiles.Default.Validators;

public class OncePerSkillTreeValidator : ISkillSelector
{
    private readonly ISkillSelector next;

    public OncePerSkillTreeValidator(ISkillSelector next)
    {
        this.next = next;
    }

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        var output = next.SelectSkill(input);

        if (!input.Profile.Rules.OncePerSkillTree.Contains(output.SkillInfo.Name))
        {
            return output;
        }

        var exists = input.Hero.SkillTree.Skills
            .Select(s => s.Info)
            .Any(output.SkillInfo.Equals);

        if (exists)
        {
            throw new InvalidSkillSelectionException(output.SkillInfo);
        }

        return output;
    }
}
