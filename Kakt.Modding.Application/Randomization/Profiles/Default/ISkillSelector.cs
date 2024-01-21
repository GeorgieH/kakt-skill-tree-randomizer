namespace Kakt.Modding.Application.Randomization.Profiles.Default;

public interface ISkillSelector
{
    SkillSelectorOutput SelectSkill(SkillSelectorInput input);
}