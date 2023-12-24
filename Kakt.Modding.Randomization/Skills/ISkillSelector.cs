namespace Kakt.Modding.Randomization.Skills;

public interface ISkillSelector
{
    SkillSelectorOutput SelectSkill(SkillSelectorInput input);
}