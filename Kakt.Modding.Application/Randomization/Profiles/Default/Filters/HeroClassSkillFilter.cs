using Kakt.Modding.Domain.Heroes;

namespace Kakt.Modding.Application.Randomization.Profiles.Default.Filters;

public class HeroClassSkillFilter : ISkillSelector
{
    private readonly ISkillSelector next;

    public HeroClassSkillFilter(ISkillSelector next)
    {
        this.next = next;
    }

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        var skillRepositoryAdapter = new SkillRepositoryAdapter(input.SkillRepository);

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

        input.IncludedSkills = skills;

        return this.next.SelectSkill(input);
    }
}
