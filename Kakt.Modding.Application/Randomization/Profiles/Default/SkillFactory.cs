using Kakt.Modding.Application.Skills;
using Kakt.Modding.Domain.Heroes;
using Kakt.Modding.Domain.Skills;

namespace Kakt.Modding.Application.Randomization.Profiles.Default;

public interface ISkillFactory
{
    Skill Get(Type skillType, SkillTier skillTier, int skillNumber, bool starter = false, bool hasUpgrades = true);
    Skill Get(Skill skill, SkillTier skillTier, int skillNumber, bool starter = false, bool hasUpgrades = true);
}

public class SkillFactory : ISkillFactory
{
    private readonly ISkillRepository skillRepository;
    private readonly ISkillUpgradeRepository skillUpgradeRepository;
    private readonly IRandomNumberGeneratorService randomNumberGeneratorService;

    public SkillFactory(
        ISkillRepository skillRepository,
        ISkillUpgradeRepository skillUpgradeRepository,
        IRandomNumberGeneratorService randomNumberGeneratorService)
    {
        this.skillRepository = skillRepository;
        this.skillUpgradeRepository = skillUpgradeRepository;
        this.randomNumberGeneratorService = randomNumberGeneratorService;
    }

    public Skill Get(Type skillType, SkillTier skillTier, int skillNumber, bool starter = false, bool hasUpgrades = true)
    {
        var skill = this.skillRepository.Get(skillType);
        return Get(skill, skillTier, skillNumber, starter, hasUpgrades);
    }

    public Skill Get(Skill skill, SkillTier skillTier, int skillNumber, bool starter = false, bool hasUpgrades = true)
    {
        skill.Starter = starter;
        skill.Tier = skillTier;

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
        var skillUpgrades = this.skillUpgradeRepository
            .Get(skill)
            .ToList();

        var random = this.randomNumberGeneratorService.GetRandom();

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
