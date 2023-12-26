using Kakt.Modding.Core.Skills;

namespace Kakt.Modding.Randomization.Skills.Default;

public static class SkillFactory
{
    private static readonly Random SkillUpgradesRng = new();

    public static void Build(Skill skill, SkillTier skillTier, int skillNumber, bool starter = false)
    {
        skill.Starter = starter;
        skill.Tier = skillTier;
        SetUpgrades(skill);

        var input = new SkillPositionCalculatorInput(skillNumber, skill);
        var output = SkillPositionCalculator.Calculate(input);
        skill.IconPosition = output.SkillPosition;

        if (!IsPassiveSkill(skill))
        {
            skill.Upgrades[0].IconPosition = output.SkillUpgradePosition1;
            skill.Upgrades[1].IconPosition = output.SkillUpgradePosition2;
            skill.Upgrades[2].IconPosition = output.SkillUpgradePosition3;
            skill.Upgrades[3].IconPosition = output.SkillUpgradePosition4;
        }
    }

    private static void SetUpgrades(Skill skill)
    {
        if (IsPassiveSkill(skill))
        {
            return;
        }

        var skillUpgrades = SkillHelpers
            .GetSkillUpgrades(skill.GetType())
            .ToList();

        skillUpgrades.Shuffle(SkillUpgradesRng);

        AddUpgrades(skill, skillUpgrades);

        if (skillUpgrades.Count < 4)
        {
            skillUpgrades.Shuffle(SkillUpgradesRng);
            AddUpgrades(skill, skillUpgrades.Take(4 - skillUpgrades.Count));
        }

        skill.Upgrades[2].LevelLimit = HeroLevelLimits.Five;
        skill.Upgrades[3].LevelLimit = HeroLevelLimits.Ten;
    }

    private static void AddUpgrades(Skill skill, IEnumerable<SkillUpgrade> skillUpgrades)
    {
        foreach (var skillUpgrade in skillUpgrades.Take(4))
        {
            skillUpgrade.Tier = skill.Tier;
            skill.Upgrades.Add(skillUpgrade);
        }
    }

    private static bool IsPassiveSkill(Skill skill)
    {
        return skill is not ActiveSkill
            && skill is not UpgradablePassiveSkill;
    }
}
