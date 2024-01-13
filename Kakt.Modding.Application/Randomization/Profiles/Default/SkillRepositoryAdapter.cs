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
        return GetSkills(profile.SkillPools.Arcanist.Include);
    }

    public IEnumerable<Skill> GetChampionSkills(DefaultRandomizationProfile profile)
    {
        return GetSkills(profile.SkillPools.Champion.Include);
    }

    public IEnumerable<Skill> GetDefenderSkills(DefaultRandomizationProfile profile)
    {
        return GetSkills(profile.SkillPools.Defender.Include);
    }

    public IEnumerable<Skill> GetMarksmanSkills(DefaultRandomizationProfile profile)
    {
        return GetSkills(profile.SkillPools.Marksman.Include);
    }

    public IEnumerable<Skill> GetSageSkills(DefaultRandomizationProfile profile)
    {
        return GetSkills(profile.SkillPools.Sage.Include);
    }

    public IEnumerable<Skill> GetVanguardSkills(DefaultRandomizationProfile profile)
    {
        return GetSkills(profile.SkillPools.Vanguard.Include);
    }

    private IEnumerable<Skill> GetSkills(HashSet<string> skillPool)
    {
        return this.skillRepository
            .AsEnumerable()
            .Where(x => skillPool.Contains(x.Name));
    }
}
