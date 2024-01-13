using Kakt.Modding.Domain.Skills;

namespace Kakt.Modding.Application.Skills;

public interface ISkillUpgradeRepository
{
    void Add(Skill skill, SkillUpgrade skillUpgrade);
    IEnumerable<SkillUpgrade> Get(Skill skill);
}

public class SkillUpgradeRepository : ISkillUpgradeRepository
{
    private readonly Dictionary<Skill, HashSet<SkillUpgrade>> skillUpgrades = [];

    public void Add(Skill skill, SkillUpgrade skillUpgrade)
    {
        if (skillUpgrades.TryGetValue(skill, out var upgrades))
        {
            upgrades.Add(skillUpgrade);
        }
        else
        {
            skillUpgrades.Add(skill, [skillUpgrade]);
        }
    }

    public IEnumerable<SkillUpgrade> Get(Skill skill)
    {
        var result = new List<SkillUpgrade>();
        
        foreach (var skillUpgrade in skillUpgrades[skill])
        {
            result.Add(skillUpgrade.Copy());
        }

        return result;
    }
}
