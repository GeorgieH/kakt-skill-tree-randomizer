using Kakt.Modding.Domain.Skills;

namespace Kakt.Modding.Application.Randomization.Profiles.Default.Filters;

public class UpgradablePassiveSkillFilter : ISkillSelector
{
    private readonly ISkillSelector next;

    public UpgradablePassiveSkillFilter(ISkillSelector next)
    {
        this.next = next;
    }

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        var existingSkills = input.Hero.SkillTree.Skills
            .Where(s => s!.Type == SkillType.Passive)
            .Where(s => s!.Upgradable);

        input.IncludedSkills = input.IncludedSkills
            .Where(s => s!.Type == SkillType.Passive)
            .Where(s => s!.Upgradable)
            .Except(existingSkills)!;

        return this.next.SelectSkill(input);
    }
}
