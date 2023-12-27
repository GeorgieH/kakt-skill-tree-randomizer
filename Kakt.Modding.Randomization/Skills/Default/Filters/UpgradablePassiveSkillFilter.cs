using Kakt.Modding.Core.Skills;

namespace Kakt.Modding.Randomization.Skills.Default.Filters;

public class UpgradablePassiveSkillFilter : ISkillSelector
{
    private readonly ISkillSelector next;

    public UpgradablePassiveSkillFilter(ISkillSelector next)
    {
        this.next = next;
    }

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        var existingSkillTypes = input.Hero.SkillTree.Skills
            .Where(s => s is UpgradablePassiveSkill)
            .Select(s => s.GetType());

        input.SkillTypes = input.SkillTypes.Except(existingSkillTypes);

        return this.next.SelectSkill(input);
    }
}
