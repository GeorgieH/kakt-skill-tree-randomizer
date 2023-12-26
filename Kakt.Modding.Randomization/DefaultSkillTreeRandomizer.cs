using Kakt.Modding.Core.Heroes;
using Kakt.Modding.Core.Skills;
using Kakt.Modding.Core.Skills.Strike.Champion;
using Kakt.Modding.Randomization.Skills;
using Kakt.Modding.Randomization.Skills.Default.Filters;
using Kakt.Modding.Randomization.Skills.Default.Validators;

namespace Kakt.Modding.Randomization;

public class DefaultSkillTreeRandomizer
{
    public IEnumerable<Hero> Generate()
    {
        var heroes = Heroes.GetAll();

        foreach (var hero in heroes)
        {
            hero.SkillTree.TierOneActiveSkillOne = GetBasicAttack(hero);

            hero.SkillTree.TierOneActiveSkillTwo = GetActiveSkill(hero, SkillTier.One);
            hero.SkillTree.TierOneActiveSkillThree = GetActiveSkill(hero, SkillTier.One);
            hero.SkillTree.TierTwoActiveSkillOne = GetActiveSkill(hero, SkillTier.Two);
            hero.SkillTree.TierTwoActiveSkillTwo = GetActiveSkill(hero, SkillTier.Two);
            hero.SkillTree.TierTwoActiveSkillThree = GetActiveSkill(hero, SkillTier.Two);
            hero.SkillTree.TierThreeActiveSkillOne = GetActiveSkill(hero, SkillTier.Three);
            hero.SkillTree.TierThreeActiveSkillTwo = GetActiveSkill(hero, SkillTier.Three);

            hero.SkillTree.TierOneUpgradablePassiveSkillOne = GetUpgradablePassiveSkill(hero, SkillTier.One);
            hero.SkillTree.TierTwoUpgradablePassiveSkillOne = GetUpgradablePassiveSkill(hero, SkillTier.Two);
            hero.SkillTree.TierThreeUpgradablePassiveSkillOne = GetUpgradablePassiveSkill(hero, SkillTier.Three);
            hero.SkillTree.TierThreeUpgradablePassiveSkillTwo = GetUpgradablePassiveSkill(hero, SkillTier.Three);

            hero.SkillTree.TierOnePassiveSkillOne = GetPassiveSkill(hero, SkillTier.One);
            hero.SkillTree.TierOnePassiveSkillTwo = GetPassiveSkill(hero, SkillTier.One);
            hero.SkillTree.TierOnePassiveSkillThree = GetPassiveSkill(hero, SkillTier.One);
            hero.SkillTree.TierTwoPassiveSkillOne = GetPassiveSkill(hero, SkillTier.Two);
            hero.SkillTree.TierTwoPassiveSkillTwo = GetPassiveSkill(hero, SkillTier.Two);
            hero.SkillTree.TierThreePassiveSkillOne = GetPassiveSkill(hero, SkillTier.Three);
            hero.SkillTree.TierThreePassiveSkillTwo = GetPassiveSkill(hero, SkillTier.Three);
            hero.SkillTree.TierThreePassiveSkillThree = GetPassiveSkill(hero, SkillTier.Three);
        }

        return heroes;
    }

    private static ActiveSkill GetBasicAttack(Hero hero)
    {
        Skill skill;

        if (hero is Champion)
        {
            skill = AsStarterSkill(new ChampionStrike());
        }
        else
        {
            throw new NotImplementedException();
        }

        return (ActiveSkill)skill;
    }

    private static Skill AsStarterSkill(Skill skill)
    {
        skill.Starter = true;
        skill.Tier = SkillTier.One;

        return skill;
    }

    private static ActiveSkill GetActiveSkill(Hero hero, SkillTier skillTier, bool starter = false)
    {
        var skillSelector =
            new HeroClassSkillFilter(
            new ActiveSkillFilter(
            new RandomSkillSelector()));

        var input = new SkillSelectorInput(hero);

        var skill = RetryUntilSuccessful<ActiveSkill>(hero, skillTier, input, skillSelector);
        skill.Starter = starter;

        return skill;
    }

    private static UpgradablePassiveSkill GetUpgradablePassiveSkill(Hero hero, SkillTier skillTier)
    {
        var skillSelector =
            new HeroClassSkillFilter(
            new UpgradablePassiveSkillFilter(
            new ArmourerValidator(
            new RandomSkillSelector())));

        var input = new SkillSelectorInput(hero);

        return RetryUntilSuccessful<UpgradablePassiveSkill>(hero, skillTier, input, skillSelector);
    }

    private static PassiveSkill GetPassiveSkill(Hero hero, SkillTier skillTier)
    {
        var skillSelector =
            new HeroClassSkillFilter(
            new PassiveSkillFilter(
            new ArmourerValidator(
            new RandomSkillSelector())));

        var input = new SkillSelectorInput(hero);

        return RetryUntilSuccessful<PassiveSkill>(hero, skillTier, input, skillSelector);
    }

    private static T RetryUntilSuccessful<T>(Hero hero, SkillTier skillTier, SkillSelectorInput input, ISkillSelector skillSelector) where T : Skill
    {
        T skill = null!;

        try
        {
            var output = skillSelector.SelectSkill(input);
            skill = CreateSkillInstance<T>(output.SkillType, skillTier);
        }
        catch (InvalidSkillSelectionException ex)
        {
            var excludedSkillTypes = new HashSet<Type>(input.ExcludedSkillTypes)
            {
                ex.SkillType
            };

            input = new SkillSelectorInput(hero)
            {
                ExcludedSkillTypes = excludedSkillTypes
            };

            RetryUntilSuccessful<T>(hero, skillTier, input, skillSelector);
        }

        return skill!;
    }

    private static T CreateSkillInstance<T>(Type skillType, SkillTier skillTier) where T : Skill
    {
        var skill = (T)Activator.CreateInstance(skillType)!;
        skill.Tier = skillTier;

        return skill;
    }
}
