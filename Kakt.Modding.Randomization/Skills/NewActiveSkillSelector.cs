using Kakt.Modding.Core.Skills;

namespace Kakt.Modding.Randomization.Skills;

public class NewActiveSkillSelector : ISkillSelector
{
    private readonly ISkillSelector next;

    public NewActiveSkillSelector(ISkillSelector next)
    {
        this.next = next;
    }

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        var existingActiveSkillTypes = input.Hero.Skills
            .Where(s => s is ActiveSkill)
            .Select(s => s.GetType());

        input.SkillTypes = input.SkillTypes.Except(existingActiveSkillTypes);

        var output = this.next.SelectSkill(input);

        return output;
    }
}
