namespace Kakt.Modding.Core.KnightsTale.Randomization.Profiles.Default;

public class RandomSkillSelector : ISkillSelector
{
    private readonly IRandomNumberGeneratorService randomNumberGeneratorService;

    public RandomSkillSelector(IRandomNumberGeneratorService randomNumberGeneratorService)
    {
        this.randomNumberGeneratorService = randomNumberGeneratorService;
    }

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        var skill = input.IncludedSkillInfos
            .Except(input.ExcludedSkillInfos)
            .Random(randomNumberGeneratorService.GetRandom());

        return new SkillSelectorOutput(skill);
    }
}
