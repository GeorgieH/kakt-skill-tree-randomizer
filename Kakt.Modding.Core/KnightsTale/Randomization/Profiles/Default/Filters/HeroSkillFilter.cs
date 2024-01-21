using Kakt.Modding.Core.KnightsTale.Heroes;
using Kakt.Modding.Core.KnightsTale.Skills;

namespace Kakt.Modding.Core.KnightsTale.Randomization.Profiles.Default.Filters;

public class HeroSkillFilter : ISkillSelector
{
    private readonly ISkillSelector next;
    private readonly ISkillInfoRepository skillInfoRepository;

    public HeroSkillFilter(
        ISkillSelector next,
        ISkillInfoRepository skillInfoRepository)
    {
        this.next = next;
        this.skillInfoRepository = skillInfoRepository;
    }

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        var heroName = input.Hero.GetType().Name;
        var skillPools = input.Profile.SkillPools;

        var skillPool = (DefaultRandomizationProfileSkillPool)skillPools
            .GetType()
            .GetProperty(heroName)!
            .GetValue(skillPools, null)!;

        SetSkillPool(input, skillPool);

        return next.SelectSkill(input);
    }

    private void SetSkillPool(SkillSelectorInput input, DefaultRandomizationProfileSkillPool skillPool)
    {
        var includedSkills = skillInfoRepository
            .GetAll()
            .Where(s => skillPool.Include.Any(s.Name.Equals));

        var excludedSkills = skillInfoRepository
            .GetAll()
            .Where(s => skillPool.Exclude.Any(s.Name.Equals));

        input.IncludedSkillInfos = input.IncludedSkillInfos
            .Union(includedSkills)
            .Except(excludedSkills);
    }
}
