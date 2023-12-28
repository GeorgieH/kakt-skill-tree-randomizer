using Kakt.Modding.Core.Heroes;
using Kakt.Modding.Core.Heroes.Configuration;
using Kakt.Modding.Core.Skills;

namespace Kakt.Modding.Randomization.Skills;

public static class RandomSkillPointDistributer
{
    private static readonly Random Rng = new();

    public static void Distribute(Hero hero)
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

    private static Preset GetPreset(Hero hero, int index)
    {
        Preset preset = null!;

        if (index == 0)
        {
            preset = new Preset(PresetNames.Campaign);
        }
        else if (index == 1)
        {
            if (hero is LadyBoudicea)
            {
                preset = new Preset(PresetNames.Campaign2);
            }
            else if (hero is SirLeodegrance)
            {
                preset = new Preset(PresetNames.CampaignTier2);
            }
        }

        return preset;
    }

    private static void SpendSkillPoints(Hero hero, int heroLevel, Preset preset)
    {
        var skillPool = new HashSet<ISkill>();
        var upgradeToSkillLookup = new Dictionary<SkillUpgrade, Skill>();

        foreach (var skill in hero.SkillTree.Skills)
        {
            skillPool.Add(skill!);

            foreach (var skillUpgrade in skill!.Upgrades)
            {
                skillPool.Add(skillUpgrade);
                upgradeToSkillLookup.Add(skillUpgrade, skill);
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

        while (remainingSkillPoints > 0)
        {
            var spentSkillPoints = maxSkillPoints - remainingSkillPoints;

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
                    || (s is SkillUpgrade u
                        && u.LevelLimit <= currentHeroLevel
                        && acquiredSkills.Contains(upgradeToSkillLookup[u])));

            var skill = candidateSkills.Random(Rng);
            acquiredSkills.Add(skill);
            skillPool.Remove(skill);

            remainingSkillPoints -= GetSkillCost(hero, skill);
            currentHeroLevel = ((maxSkillPoints - remainingSkillPoints) / 2) + 1;
        }

        foreach (var skill in acquiredSkills)
        {
            preset.LearnedSkills.Add(skill);
        }
    }

    private static int GetSkillCost(Hero hero, ISkill skill)
    {
        if (skill is ActiveSkill)
        {
            // Talented
            if (hero is SirKay || hero is SirBedievere)
            {
                return 1;
            }

            // Conservative
            if (hero is SirGawain)
            {
                return 3;
            }

            return 2;
        }

        if (skill is PassiveSkill)
        {
            return 2;
        }

        return 1;
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
            LadyMorganaLeFey => [14],
            LadyMorgawse => [9],
            Merlin => [9],
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
