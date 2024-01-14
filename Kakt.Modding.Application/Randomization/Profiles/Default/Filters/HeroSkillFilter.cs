using Kakt.Modding.Domain.Heroes;

namespace Kakt.Modding.Application.Randomization.Profiles.Default.Filters;

public class HeroSkillFilter : ISkillSelector
{
    private readonly ISkillSelector next;

    public HeroSkillFilter(ISkillSelector next)
    {
        this.next = next;
    }

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        switch (input.Hero)
        {
            case BlackKnight:
                SetSkillPool(input, input.Profile.SkillPools.BlackKnight);
                break;
            case FaerieKnight:
                SetSkillPool(input, input.Profile.SkillPools.FaerieKnight);
                break;
            default:
                throw new NotImplementedException();
        }

        return this.next.SelectSkill(input);
    }

    private static void SetSkillPool(
        SkillSelectorInput input, DefaultRandomizationProfileSkillPool skillPool)
    {
        var includedSkills = input.SkillRepository.GetAll(skillPool.Include);
        var excludedSkills = input.SkillRepository.GetAll(skillPool.Exclude);

        input.IncludedSkills = input.IncludedSkills.Union(includedSkills).Except(excludedSkills);
    }
}
