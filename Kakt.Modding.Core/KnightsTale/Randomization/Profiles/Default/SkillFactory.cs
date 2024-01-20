using Kakt.Modding.Core.KnightsTale.Heroes;
using Kakt.Modding.Core.KnightsTale.Skills;

namespace Kakt.Modding.Core.KnightsTale.Randomization.Profiles.Default;

public interface ISkillFactory
{
    Skill Get(
        SkillInfo skillInfo,
        SkillTier skillTier,
        int skillNumber,
        bool starter = false,
        bool hasUpgrades = true);
}

public class SkillFactory : ISkillFactory
{
    private readonly ISkillUpgradeInfoRepository skillUpgradeInfoRepository;
    private readonly IRandomNumberGeneratorService randomNumberGeneratorService;

    public SkillFactory(
        ISkillUpgradeInfoRepository skillUpgradeInfoRepository,
        IRandomNumberGeneratorService randomNumberGeneratorService)
    {
        this.skillUpgradeInfoRepository = skillUpgradeInfoRepository;
        this.randomNumberGeneratorService = randomNumberGeneratorService;
    }

    public Skill Get(
        SkillInfo skillInfo,
        SkillTier skillTier,
        int skillNumber,
        bool starter = false,
        bool hasUpgrades = true)
    {
        var skill = new Skill(skillInfo)
        {
            Starter = starter,
            Tier = skillTier
        };

        if (hasUpgrades)
        {
            AddUpgrades(skill);
        }

        SetIconPositions(skill, skillNumber, hasUpgrades);

        foreach (var skillUpgrade in skill.Upgrades)
        {
            skillUpgrade.Tier = skill.Tier;
        }

        return skill;
    }

    private void AddUpgrades(Skill skill)
    {
        var skillUpgrades = GetSkillUpgrades(skill);

        AddUpgrades(skill, skillUpgrades);

        if (skillUpgrades.Count < 4)
        {
            skillUpgrades = GetSkillUpgrades(skill);
            AddUpgrades(skill, skillUpgrades.Take(4 - skillUpgrades.Count));
        }

        skill.Upgrades[0].LevelLimit = 0;
        skill.Upgrades[1].LevelLimit = 0;
        skill.Upgrades[2].LevelLimit = HeroLevelRequirementThresholds.Five;
        skill.Upgrades[3].LevelLimit = HeroLevelRequirementThresholds.Ten;
    }

    private List<SkillUpgrade> GetSkillUpgrades(Skill skill)
    {
        var skillUpgrades = skillUpgradeInfoRepository
            .Get(skill.Info)
            .Select(i => new SkillUpgrade(i))
            .ToList();

        var random = randomNumberGeneratorService.GetRandom();

        skillUpgrades.Shuffle(random);

        return skillUpgrades;
    }

    private static void AddUpgrades(Skill skill, IEnumerable<SkillUpgrade> skillUpgrades)
    {
        foreach (var skillUpgrade in skillUpgrades.Take(4))
        {
            skillUpgrade.Tier = skill.Tier;
            skill.Upgrades.Add(skillUpgrade);
        }
    }

    private static void SetIconPositions(Skill skill, int skillNumber, bool hasUpgrades)
    {
        var input = new SkillPositionCalculatorInput(skillNumber, skill);
        var output = SkillPositionCalculator.Calculate(input);
        skill.IconPosition = output.SkillPosition;

        if (hasUpgrades)
        {
            skill.Upgrades[0].IconPosition = output.SkillUpgradePosition1;
            skill.Upgrades[1].IconPosition = output.SkillUpgradePosition2;
            skill.Upgrades[2].IconPosition = output.SkillUpgradePosition3;
            skill.Upgrades[3].IconPosition = output.SkillUpgradePosition4;
        }
    }
}
