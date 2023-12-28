using Kakt.Modding.Core.Skills;

namespace Kakt.Modding.Randomization.Skills.Default;

public static class SkillFactory
{
    private static readonly Random SkillUpgradesRng = new();

    public static void Build(Skill skill, SkillTier skillTier, int skillNumber, bool starter = false, bool hasUpgrades = true)
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
    }

    private static void AddUpgrades(Skill skill)
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
        skill.Upgrades[2].LevelLimit = HeroLevelLimits.Five;
        skill.Upgrades[3].LevelLimit = HeroLevelLimits.Ten;
    }

    private static List<SkillUpgrade> GetSkillUpgrades(Skill skill)
    {
        var skillUpgrades = SkillHelpers
            .GetSkillUpgrades(skill.GetType())
            .ToList();

        skillUpgrades.Shuffle(SkillUpgradesRng);

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
