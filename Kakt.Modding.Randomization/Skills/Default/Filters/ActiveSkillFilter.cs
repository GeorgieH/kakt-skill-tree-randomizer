using Kakt.Modding.Core.Skills;

namespace Kakt.Modding.Randomization.Skills.Default.Filters;

public class ActiveSkillFilter : ISkillSelector
{
    private readonly ISkillSelector next;

    public ActiveSkillFilter(ISkillSelector next)
    {
        this.next = next;
    }

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        var existingActiveSkillTypes = input.Hero.SkillTree.Skills
            .Where(s => s is ActiveSkill)
            .Select(s => s.GetType());

        input.SkillTypes = input.SkillTypes.Except(existingActiveSkillTypes);

        var output = this.next.SelectSkill(input);

        return output;
    }
}
