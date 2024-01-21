using Kakt.Modding.Core.KnightsTale.Skills;

namespace Kakt.Modding.Core.KnightsTale.Randomization.Profiles.Default.Filters;

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
            .Where(s => s.Type == SkillType.Passive)
            .Where(s => s.Upgradable)
            .Select(s => s.Info);

        input.IncludedSkillInfos = input.IncludedSkillInfos
            .Where(s => s.Type == SkillType.Passive)
            .Where(s => s.Upgradable)
            .Except(existingSkills);

        return next.SelectSkill(input);
    }
}
