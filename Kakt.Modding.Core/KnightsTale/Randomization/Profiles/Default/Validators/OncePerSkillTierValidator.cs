namespace Kakt.Modding.Core.KnightsTale.Randomization.Profiles.Default.Validators;

public class OncePerSkillTierValidator : ISkillSelector
{
    private readonly ISkillSelector next;

    public OncePerSkillTierValidator(ISkillSelector next)
    {
        this.next = next;
    }

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        var output = next.SelectSkill(input);

        if (!input.Profile.Rules.OncePerSkillTier.Contains(output.SkillInfo.Name))
        {
            return output;
        }

        var exists = input.Hero.SkillTree.Skills
            .Where(s => s.Tier == input.SkillTier)
            .Select(s => s.Info)
            .Any(output.SkillInfo.Equals);

        if (exists)
        {
            throw new InvalidSkillSelectionException(output.SkillInfo);
        }

        return output;
    }
}
