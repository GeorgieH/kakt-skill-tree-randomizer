using Kakt.Modding.Domain.Skills;

namespace Kakt.Modding.Application.Skills;

public interface ISkillUpgradeRepository
{
    void Add(Skill skill, SkillUpgrade skillUpgrade);
}

public class SkillUpgradeRepository : ISkillUpgradeRepository
{
    private readonly Dictionary<Skill, SkillUpgrade> skillUpgrades = [];

    public void Add(Skill skill, SkillUpgrade skillUpgrade)
    {
        skillUpgrades.Add(skill, skillUpgrade);
    }
}
