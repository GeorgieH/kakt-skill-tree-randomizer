namespace Kakt.Modding.Randomization.Skills.Default.Filters;

public class PassiveSkillFilter : ISkillSelector
{
    private readonly ISkillSelector next;

    public PassiveSkillFilter(ISkillSelector next)
    {
        this.next = next;
    }

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        throw new NotImplementedException();
    }
}
