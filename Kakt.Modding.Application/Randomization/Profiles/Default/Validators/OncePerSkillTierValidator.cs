namespace Kakt.Modding.Application.Randomization.Profiles.Default.Validators;

public class OncePerSkillTierValidator : ISkillSelector
{
    private static readonly HashSet<string> Skills =
    [
        SkillNames.Robust,
        SkillNames.MarksmanScout,
        SkillNames.VanguardScout,
        SkillNames.Strength
    ];

    private readonly ISkillSelector next;

    public OncePerSkillTierValidator(ISkillSelector next)
    {
        this.next = next;
    }

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        var output = this.next.SelectSkill(input);

        if (!Skills.Contains(output.Skill.Name))
        {
            return output;
        }

        var exists = input.Hero.SkillTree.Skills
            .Where(s => s is not null)
            .Where(s => s!.Tier == input.SkillTier)
            .Any(output.Skill.Equals);

        if (exists)
        {
            throw new InvalidSkillSelectionException(output.Skill);
        }

        return output;
    }
}
