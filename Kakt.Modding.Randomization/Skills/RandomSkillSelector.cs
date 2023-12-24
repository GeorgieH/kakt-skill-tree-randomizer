namespace Kakt.Modding.Randomization.Skills;

public class RandomSkillSelector : ISkillSelector
{
    private static readonly Random random = new();

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        var skillType = input.SkillTypes.Random(random);
        return new SkillSelectorOutput(skillType);
    }
}
