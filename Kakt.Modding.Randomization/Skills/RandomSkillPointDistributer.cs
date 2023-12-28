using Kakt.Modding.Core.Heroes;
using Kakt.Modding.Core.Heroes.Configuration;
using Kakt.Modding.Core.Skills;

namespace Kakt.Modding.Randomization.Skills;

public static class RandomSkillPointDistributer
{
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
            SpendSkillPoints(hero, preset, level);
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

    private static void SpendSkillPoints(Hero hero, Preset preset, int level)
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

        var skillPoints = (level - 1) * 2;
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
