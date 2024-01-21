namespace Kakt.Modding.Core.KnightsTale.Randomization.Profiles.Default;

public interface ISkillSelector
{
    SkillSelectorOutput SelectSkill(SkillSelectorInput input);
}