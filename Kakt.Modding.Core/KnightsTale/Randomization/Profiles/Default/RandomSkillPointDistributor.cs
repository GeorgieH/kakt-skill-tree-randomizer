using Kakt.Modding.Core.KnightsTale.Heroes;
using Kakt.Modding.Core.KnightsTale.Skills;

namespace Kakt.Modding.Core.KnightsTale.Randomization.Profiles.Default;

public interface IRandomSkillPointDistributor
{
    void Distribute(Hero hero);
}

public class RandomSkillPointDistributor : IRandomSkillPointDistributor
{
    private readonly IRandomNumberGeneratorService randomNumberGeneratorService;

    public RandomSkillPointDistributor(IRandomNumberGeneratorService randomNumberGeneratorService)
    {
        this.randomNumberGeneratorService = randomNumberGeneratorService;
    }

    public void Distribute(Hero hero)
    {
        var startingLevels = GetStartingLevels(hero);

        for (var i = 0; i < startingLevels.Length; i++)
        {
            var level = startingLevels[i];

            if (level == 1)
            {
                continue;
            }

            var preset = GetPreset(hero, i);
            SpendSkillPoints(hero, level, preset);
            hero.Presets.Add(preset);
        }
    }

    private static HeroPreset GetPreset(Hero hero, int index)
    {
        HeroPreset preset = null!;

        if (index == 0)
        {
            if (hero is Merlin)
            {
                preset = new HeroPreset(HeroPresetNames.Act2WitchQueen);
            }
            else
            {
                preset = new HeroPreset(HeroPresetNames.Campaign);
            }
        }
        else if (index == 1)
        {
            if (hero is LadyBoudicea)
            {
                preset = new HeroPreset(HeroPresetNames.Campaign2);
            }
            else if (hero is Merlin)
            {
                preset = new HeroPreset(HeroPresetNames.Campaign);
            }
            else if (hero is SirLeodegrance)
            {
                preset = new HeroPreset(HeroPresetNames.CampaignTier2);
            }
        }

        return preset;
    }

    private void SpendSkillPoints(Hero hero, int heroLevel, HeroPreset preset)
    {
        var skillPool = new HashSet<ISkill>();
        var upgradeToSkillLookup = new Dictionary<SkillUpgrade, Skill>();

        foreach (var skill in hero.SkillTree.Skills)
        {
            skillPool.Add(skill!);

            foreach (var skillUpgrade in skill!.Upgrades)
            {
                skillPool.Add(skillUpgrade);

                if (!upgradeToSkillLookup.ContainsKey(skillUpgrade))
                {
                    upgradeToSkillLookup.Add(skillUpgrade, skill);
                }
            }
        }

        var acquiredSkills = new HashSet<ISkill>();

        foreach (var skill in skillPool)
        {
            if (skill is Skill s && s.Starter)
            {
                acquiredSkills.Add(skill);
                skillPool.Remove(skill);
            }
        }

        var currentHeroLevel = 1;
        var maxSkillPoints = (heroLevel - 1) * 2;
        var remainingSkillPoints = maxSkillPoints;
        var spentSkillPoints = 0;
        var bonusSkillPoints = 0;

        while (remainingSkillPoints > 0)
        {
            var maxSkillTier = spentSkillPoints switch
            {
                < 8 => SkillTier.One,
                < 24 => SkillTier.Two,
                _ => SkillTier.Three,
            };

            var candidateSkills = skillPool
                .Where(s => (int)s.Tier <= (int)maxSkillTier)
                .Where(s => GetSkillCost(hero, s) <= remainingSkillPoints)
                .Where(s => s is Skill
                    || s is SkillUpgrade u
                        && u.LevelLimit <= currentHeroLevel
                        && acquiredSkills.Contains(upgradeToSkillLookup[u]));

            var skill = candidateSkills.Random(randomNumberGeneratorService.GetRandom());

            acquiredSkills.Add(skill);
            skillPool.Remove(skill);

            spentSkillPoints += GetSkillCost(hero, skill);
            remainingSkillPoints = maxSkillPoints + bonusSkillPoints - spentSkillPoints;
            currentHeroLevel = (spentSkillPoints - bonusSkillPoints) / 2 + 1;

            if (heroLevel % 5 == 0
                && hero.Traits.HasFlag(HeroTraits.Skilled))
            {
                bonusSkillPoints++;
                remainingSkillPoints++;
            }
        }

        foreach (var skill in acquiredSkills)
        {
            preset.LearnedSkills.Add(skill);
        }
    }

    private static int GetSkillCost(Hero hero, ISkill skill)
    {
        if (skill is Skill s)
        {
            if (s.Type == SkillType.Active)
            {
                if (hero.Traits.HasFlag(HeroTraits.Frigid) && IsIceSkill(s))
                {
                    return 1;
                }

                if (hero.Traits.HasFlag(HeroTraits.Talented))
                {
                    return 1;
                }

                if (hero.Traits.HasFlag(HeroTraits.Conservative))
                {
                    return 3;
                }

                return 2;
            }

            if (s.Type == SkillType.Passive)
            {
                if (hero.Traits.HasFlag(HeroTraits.Frigid) && IsIceSkill(s))
                {
                    return 1;
                }

                return 2;
            }
        }

        return 1;
    }

    private static bool IsIceSkill(Skill skill)
    {
        return skill.Attributes.HasFlag(SkillAttributes.Ice);
    }

    private static int[] GetStartingLevels(Hero hero)
    {
        return hero switch
        {
            BlackKnight => [8],
            FaerieKnight => [12],
            LadyBoudicea => [9, 12],
            LadyDindraine => [1],
            LadyGuinevere => [8],
            LadyIsolde => [10],
            LadyMorganaLeFay => [14],
            LadyMorgawse => [9],
            Merlin => [8, 9],
            RedKnight => [15],
            SirBalan => [3],
            SirBalin => [3],
            SirBedievere => [9],
            SirBors => [8],
            SirBrunorLeNoir => [7],
            SirDagonet => [10],
            SirDamas => [10],
            SirEctor => [3],
            SirGalahad => [14],
            SirGawain => [12],
            SirGeraint => [10],
            SirKay => [1],
            SirLancelot => [15],
            SirLanval => [3],
            SirLeodegrance => [3, 8],
            SirLucan => [10],
            SirMordred => [1],
            SirPelleas => [4],
            SirPercival => [10],
            SirTegyr => [7],
            SirTristan => [4],
            SirYvain => [3],
            WhiteKnight => [9],
            _ => throw new NotImplementedException(),
        };
    }
}
