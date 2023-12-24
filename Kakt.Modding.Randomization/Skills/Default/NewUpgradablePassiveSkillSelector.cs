namespace Kakt.Modding.Randomization.Skills.Default;

public class NewUpgradablePassiveSkillSelector
{
    private readonly ISkillSelector next;

    public NewUpgradablePassiveSkillSelector(ISkillSelector next)
    {
        this.next = next;
    }

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        throw new NotImplementedException();
    }
}
