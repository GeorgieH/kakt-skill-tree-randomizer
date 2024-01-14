using Kakt.Modding.Application.Skills;
using Kakt.Modding.Domain.Skills;

namespace Kakt.Modding.Application.Randomization.Profiles.Default;

public class SkillRepositoryAdapter
{
    private readonly ISkillRepository skillRepository;

    public SkillRepositoryAdapter(ISkillRepository skillRepository)
    {
        this.skillRepository = skillRepository;
    }

    public IEnumerable<Skill> GetArcanistSkills(DefaultRandomizationProfile profile)
    {
        return GetSkills(profile.SkillPools.Arcanist);
    }

    public IEnumerable<Skill> GetChampionSkills(DefaultRandomizationProfile profile)
    {
        return GetSkills(profile.SkillPools.Champion);
    }

    public IEnumerable<Skill> GetDefenderSkills(DefaultRandomizationProfile profile)
    {
        return GetSkills(profile.SkillPools.Defender);
    }

    public IEnumerable<Skill> GetMarksmanSkills(DefaultRandomizationProfile profile)
    {
        return GetSkills(profile.SkillPools.Marksman);
    }

    public IEnumerable<Skill> GetSageSkills(DefaultRandomizationProfile profile)
    {
        return GetSkills(profile.SkillPools.Sage);
    }

    public IEnumerable<Skill> GetVanguardSkills(DefaultRandomizationProfile profile)
    {
        return GetSkills(profile.SkillPools.Vanguard);
    }

    private IEnumerable<Skill> GetSkills(DefaultRandomizationProfileSkillPool skillPool)
    {
        return this.skillRepository
            .AsEnumerable()
            .Where(s => skillPool.Include.Contains(s.Name))
            .Where(s => !skillPool.Exclude.Contains(s.Name));
    }
}
