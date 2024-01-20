using Kakt.Modding.Core.KnightsTale.Skills;

namespace Kakt.Modding.Core.KnightsTale.Randomization.Profiles.Default;

public class SkillRepositoryAdapter
{
    private readonly ISkillInfoRepository skillInfoRepository;

    public SkillRepositoryAdapter(ISkillInfoRepository skillInfoRepository)
    {
        this.skillInfoRepository = skillInfoRepository;
    }

    public IEnumerable<SkillInfo> GetArcanistSkills(DefaultRandomizationProfile profile)
    {
        return GetSkillInfos(profile.SkillPools.Common, profile.SkillPools.Arcanist);
    }

    public IEnumerable<SkillInfo> GetChampionSkills(DefaultRandomizationProfile profile)
    {
        return GetSkillInfos(profile.SkillPools.Common, profile.SkillPools.Champion);
    }

    public IEnumerable<SkillInfo> GetDefenderSkills(DefaultRandomizationProfile profile)
    {
        return GetSkillInfos(profile.SkillPools.Common, profile.SkillPools.Defender);
    }

    public IEnumerable<SkillInfo> GetMarksmanSkills(DefaultRandomizationProfile profile)
    {
        return GetSkillInfos(profile.SkillPools.Common, profile.SkillPools.Marksman);
    }

    public IEnumerable<SkillInfo> GetSageSkills(DefaultRandomizationProfile profile)
    {
        return GetSkillInfos(profile.SkillPools.Common, profile.SkillPools.Sage);
    }

    public IEnumerable<SkillInfo> GetVanguardSkills(DefaultRandomizationProfile profile)
    {
        return GetSkillInfos(profile.SkillPools.Common, profile.SkillPools.Vanguard);
    }

    private IEnumerable<SkillInfo> GetSkillInfos(
        DefaultRandomizationProfileSkillPool commonSkillPool,
        DefaultRandomizationProfileSkillPool heroClassSkillPool)
    {
        return skillInfoRepository
            .GetAll()
            .Where(s => commonSkillPool.Include.Contains(s.Name) || heroClassSkillPool.Include.Contains(s.Name))
            .Where(s => !heroClassSkillPool.Exclude.Contains(s.Name));
    }
}
