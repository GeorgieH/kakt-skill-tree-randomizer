namespace Kakt.Modding.Application.Randomization.Profiles.Default;

public class RandomSkillSelector : ISkillSelector
{
    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        var skill = input.IncludedSkills
            .Except(input.ExcludedSkills)
            .Random(input.RandomNumberGeneratorService.GetRandom());

        return new SkillSelectorOutput(skill);
    }
}
