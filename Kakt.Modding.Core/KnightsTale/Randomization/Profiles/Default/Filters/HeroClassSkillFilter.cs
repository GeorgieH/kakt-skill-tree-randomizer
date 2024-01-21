using Kakt.Modding.Core.KnightsTale.Heroes;
using Kakt.Modding.Core.KnightsTale.Skills;

namespace Kakt.Modding.Core.KnightsTale.Randomization.Profiles.Default.Filters;

public class HeroClassSkillFilter : ISkillSelector
{
    private readonly ISkillSelector next;
    private readonly ISkillInfoRepository skillInfoRepository;

    public HeroClassSkillFilter(
        ISkillSelector next,
        ISkillInfoRepository skillInfoRepository)
    {
        this.next = next;
        this.skillInfoRepository = skillInfoRepository;
    }

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        var skillRepositoryAdapter = new SkillRepositoryAdapter(skillInfoRepository);

        var skills = input.Hero switch
        {
            Arcanist => skillRepositoryAdapter.GetArcanistSkills(input.Profile),
            Champion => skillRepositoryAdapter.GetChampionSkills(input.Profile),
            Defender => skillRepositoryAdapter.GetDefenderSkills(input.Profile),
            Marksman => skillRepositoryAdapter.GetMarksmanSkills(input.Profile),
            Sage => skillRepositoryAdapter.GetSageSkills(input.Profile),
            Vanguard => skillRepositoryAdapter.GetVanguardSkills(input.Profile),
            _ => throw new NotImplementedException()
        };

        input.IncludedSkillInfos = skills;

        return next.SelectSkill(input);
    }
}
