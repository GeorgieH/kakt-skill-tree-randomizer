namespace Kakt.Modding.Core.KnightsTale.Skills;

public interface ISkillUpgradeInfoRepository
{
    void Add(SkillInfo skillInfo, SkillUpgradeInfo skillUpgradeInfo);
    IEnumerable<SkillUpgradeInfo> Get(SkillInfo skillInfo);
}

public class SkillUpgradeInfoRepository : ISkillUpgradeInfoRepository
{
    private readonly Dictionary<SkillInfo, HashSet<SkillUpgradeInfo>> upgrades = [];

    public void Add(SkillInfo skillInfo, SkillUpgradeInfo skillUpgradeInfo)
    {
        if (this.upgrades.TryGetValue(skillInfo, out var upgrades))
        {
            upgrades.Add(skillUpgradeInfo);
        }
        else
        {
            this.upgrades.Add(skillInfo, [skillUpgradeInfo]);
        }
    }

    public IEnumerable<SkillUpgradeInfo> Get(SkillInfo skillInfo)
    {
        return this.upgrades[skillInfo];
    }
}
