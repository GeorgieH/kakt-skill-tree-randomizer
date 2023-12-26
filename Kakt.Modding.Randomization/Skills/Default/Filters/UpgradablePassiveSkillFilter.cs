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
        throw new NotImplementedException();
    }
}
