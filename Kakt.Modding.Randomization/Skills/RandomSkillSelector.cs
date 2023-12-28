namespace Kakt.Modding.Randomization.Skills;

public class RandomSkillSelector : ISkillSelector
{
    private static readonly Random Rng = new();

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        var skillType = input.SkillTypes
            .Except(input.ExcludedSkillTypes)
            .Random(Rng);

        return new SkillSelectorOutput(skillType);
    }
}
