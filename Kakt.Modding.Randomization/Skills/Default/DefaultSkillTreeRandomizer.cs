﻿using Kakt.Modding.Core.Heroes;
using Kakt.Modding.Core.Skills;
using Kakt.Modding.Core.Skills.FireBolt;
using Kakt.Modding.Core.Skills.ForceBolt;
using Kakt.Modding.Core.Skills.IceBolt;
using Kakt.Modding.Core.Skills.LightningStrike;
using Kakt.Modding.Core.Skills.ShadowBolt;
using Kakt.Modding.Core.Skills.Shoot;
using Kakt.Modding.Core.Skills.Strike.Champion;
using Kakt.Modding.Core.Skills.Strike.Defender;
using Kakt.Modding.Core.Skills.Strike.Sage;
using Kakt.Modding.Core.Skills.Strike.Vanguard;
using Kakt.Modding.Randomization.Skills.Default.Filters;
using Kakt.Modding.Randomization.Skills.Default.Validators;

namespace Kakt.Modding.Randomization.Skills.Default;

public class DefaultSkillTreeRandomizer
{
    private static readonly Random BasicArcanistSkillsRng = new();

    private static readonly List<ActiveSkill> BasicArcanistSkills =
    [
        new FireBolt(),
        new ForceBolt(),
        new IceBolt(),
        new ShadowBolt()
    ];

    public IEnumerable<Hero> Generate()
    {
        var heroes = Heroes.GetAll();

        foreach (var hero in heroes)
        {
            hero.SkillTree.TierOneActiveSkillOne = GetBasicAttack(hero);
            hero.SkillTree.TierOneActiveSkillTwo = GetActiveSkill(hero, SkillTier.One, 2);
            hero.SkillTree.TierOneActiveSkillThree = GetActiveSkill(hero, SkillTier.One, 3, true);
            hero.SkillTree.TierOneUpgradablePassiveSkillOne = GetUpgradablePassiveSkill(hero, SkillTier.One, 4);
            hero.SkillTree.TierOnePassiveSkillOne = GetPassiveSkill(hero, SkillTier.One, 5);
            hero.SkillTree.TierOnePassiveSkillTwo = GetPassiveSkill(hero, SkillTier.One, 6);
            hero.SkillTree.TierOnePassiveSkillThree = GetPassiveSkill(hero, SkillTier.One, 7);

            hero.SkillTree.TierTwoActiveSkillOne = GetActiveSkill(hero, SkillTier.Two, 8);
            hero.SkillTree.TierTwoActiveSkillTwo = GetActiveSkill(hero, SkillTier.Two, 9);
            hero.SkillTree.TierTwoActiveSkillThree = GetActiveSkill(hero, SkillTier.Two, 11);
            hero.SkillTree.TierTwoUpgradablePassiveSkillOne = GetUpgradablePassiveSkill(hero, SkillTier.Two, 10);
            hero.SkillTree.TierTwoPassiveSkillOne = GetPassiveSkill(hero, SkillTier.Two, 12);
            hero.SkillTree.TierTwoPassiveSkillTwo = GetPassiveSkill(hero, SkillTier.Two, 13);

            hero.SkillTree.TierThreeActiveSkillOne = GetActiveSkill(hero, SkillTier.Three, 14);
            hero.SkillTree.TierThreeActiveSkillTwo = GetActiveSkill(hero, SkillTier.Three, 17);
            hero.SkillTree.TierThreeUpgradablePassiveSkillOne = GetUpgradablePassiveSkill(hero, SkillTier.Three, 15);
            hero.SkillTree.TierThreeUpgradablePassiveSkillTwo = GetUpgradablePassiveSkill(hero, SkillTier.Three, 16);
            hero.SkillTree.TierThreePassiveSkillOne = GetPassiveSkill(hero, SkillTier.Three, 18);
            hero.SkillTree.TierThreePassiveSkillTwo = GetPassiveSkill(hero, SkillTier.Three, 19);
            hero.SkillTree.TierThreePassiveSkillThree = GetPassiveSkill(hero, SkillTier.Three, 20);
        }

        return heroes;
    }

    private static ActiveSkill GetBasicAttack(Hero hero)
    {
        Skill skill;

        if (hero is FaerieKnight)
        {
            skill = new LightningStrike();
        }
        else if (hero is Arcanist)
        {
            BasicArcanistSkills.Shuffle(BasicArcanistSkillsRng);
            skill = BasicArcanistSkills.First();
        }
        else if (hero is Champion)
        {
            skill = new ChampionStrike();
        }
        else if (hero is Defender)
        {
            skill = new DefenderStrike();
        }
        else if (hero is Marksman)
        {
            skill = new Shoot();
        }
        else if (hero is Sage)
        {
            skill = new SageStrike();
        }
        else if (hero is Vanguard)
        {
            skill = new VanguardStrike();
        }
        else
        {
            throw new NotImplementedException();
        }

        SkillFactory.Build(skill, SkillTier.One, 1, true);

        return (ActiveSkill)skill;
    }

    private static ActiveSkill GetActiveSkill(Hero hero, SkillTier skillTier, int skillNumber, bool starter = false)
    {
        var skillSelector =
            new HeroClassSkillFilter(
            new ActiveSkillFilter(
            new RandomSkillSelector()));

        var input = new SkillSelectorInput(hero, skillTier);
        var skill = GetSkill<ActiveSkill>(hero, skillTier, input, skillSelector);
        SkillFactory.Build(skill, skillTier, skillNumber, starter);

        return skill;
    }

    private static UpgradablePassiveSkill GetUpgradablePassiveSkill(Hero hero, SkillTier skillTier, int skillNumber)
    {
        var skillSelector =
            new HeroClassSkillFilter(
            new UpgradablePassiveSkillFilter(
            new OncePerSkillTreeValidator(
            new OncePerSkillTierValidator(
            new SkillAttributeValidator(
            new EffectValidator(
            new ArmourerValidator(
            new RandomSkillSelector())))))));

        var input = new SkillSelectorInput(hero, skillTier);
        var skill = GetSkill<UpgradablePassiveSkill>(hero, skillTier, input, skillSelector);
        SkillFactory.Build(skill, skillTier, skillNumber);

        return skill;
    }

    private static PassiveSkill GetPassiveSkill(Hero hero, SkillTier skillTier, int skillNumber)
    {
        var skillSelector =
            new HeroClassSkillFilter(
            new PassiveSkillFilter(
            new OncePerSkillTreeValidator(
            new OncePerSkillTierValidator(
            new SkillAttributeValidator(
            new EffectValidator(
            new ArmourerValidator(
            new RandomSkillSelector())))))));

        var input = new SkillSelectorInput(hero, skillTier);
        var skill = GetSkill<PassiveSkill>(hero, skillTier, input, skillSelector);
        SkillFactory.Build(skill, skillTier, skillNumber);

        return skill;
    }

    private static T GetSkill<T>(Hero hero, SkillTier skillTier, SkillSelectorInput input, ISkillSelector skillSelector) where T : Skill
    {
        T skill = null!;

        try
        {
            var output = skillSelector.SelectSkill(input);
            skill = (T)Activator.CreateInstance(output.SkillType)!;
        }
        catch (InvalidSkillSelectionException ex)
        {
            var excludedSkillTypes = input.ExcludedSkillTypes;
            excludedSkillTypes.Add(ex.SkillType);

            input = new SkillSelectorInput(hero, skillTier)
            {
                ExcludedSkillTypes = excludedSkillTypes
            };

            GetSkill<T>(hero, skillTier, input, skillSelector);
        }

        return skill!;
    }
}
