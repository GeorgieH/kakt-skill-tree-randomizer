namespace Kakt.Modding.Randomization.Skills.Default;

public class NewPassiveSkillSelector : ISkillSelector
{
    private readonly ISkillSelector next;

    public NewPassiveSkillSelector(ISkillSelector next)
    {
        this.next = next;
    }

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        throw new NotImplementedException();
    }
}
