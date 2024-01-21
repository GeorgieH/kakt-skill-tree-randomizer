using Kakt.Modding.Core.KnightsTale.Heroes;

namespace Kakt.Modding.Core.KnightsTale.Randomization.Profiles.Default.Validators;

public class ArmourerValidator : ISkillSelector
{
    private readonly ISkillSelector next;

    public ArmourerValidator(ISkillSelector next)
    {
        this.next = next;
    }

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        var output = next.SelectSkill(input);

        var hero = input.Hero;

        if (output.SkillInfo.Name.Equals(SkillNames.Armourer))
        {
            if (hero is not Champion
                && hero is not Defender
                && !hero.SkillTree.Skills.Select(s => s.Name).Any(SkillNames.Ironclad.Equals))
            {
                throw new InvalidSkillSelectionException(output.SkillInfo);
            }
        }

        return output;
    }
}
