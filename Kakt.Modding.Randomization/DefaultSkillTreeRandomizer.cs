using Kakt.Modding.Core.Heroes;
using Kakt.Modding.Core.Skills;
using Kakt.Modding.Core.Skills.Strike.Champion;
using Kakt.Modding.Randomization.Skills;
using Kakt.Modding.Randomization.Skills.Default;

namespace Kakt.Modding.Randomization;

public class DefaultSkillTreeRandomizer
{
    public IEnumerable<Hero> Generate()
    {
        var heroes = Heroes.GetAll();

        foreach (var hero in heroes)
        {
            // Tier 1
            AssignBasicAttack(hero);
            AddActiveSkill(hero, SkillTier.One);
            AddActiveSkill(hero, SkillTier.One, true);
            AddUpgradablePassiveSkill(hero, SkillTier.One);
            AddPassiveSkill(hero, SkillTier.One);
            AddPassiveSkill(hero, SkillTier.One);
            AddPassiveSkill(hero, SkillTier.One);

            // Tier 2
            AddActiveSkill(hero, SkillTier.Two);
            AddActiveSkill(hero, SkillTier.Two);
            AddUpgradablePassiveSkill(hero, SkillTier.Two);
            AddActiveSkill(hero, SkillTier.Two);
            AddPassiveSkill(hero, SkillTier.Two);
            AddPassiveSkill(hero, SkillTier.Two);

            // Tier 3
            AddActiveSkill(hero, SkillTier.Three);
            AddUpgradablePassiveSkill(hero, SkillTier.Three);
            AddUpgradablePassiveSkill(hero, SkillTier.Three);
            AddActiveSkill(hero, SkillTier.Three);
            AddPassiveSkill(hero, SkillTier.Three);
            AddPassiveSkill(hero, SkillTier.Three);
            AddPassiveSkill(hero, SkillTier.Three);
        }

        return heroes;
    }

    private static void AssignBasicAttack(Hero hero)
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

        hero.AddSkill(skill);
    }

    private static Skill AsStarterSkill(Skill skill)
    {
        skill.Starter = true;
        skill.Tier = SkillTier.One;

        return skill;
    }

    private static void AddActiveSkill(Hero hero, SkillTier skillTier, bool starter = false)
    {
        var selector =
            new NewActiveSkillSelector(
            new HeroClassSkillSelector(
            new RandomSkillSelector()));

        var input = new SkillSelectorInput(hero, Core.Skills.Skills.ActiveSkillTypes);
        var output = selector.SelectSkill(input);
        var skill = CreateSkillInstance(output.SkillType, skillTier);
        skill.Starter = starter;
        hero.AddSkill(skill);
    }

    private static void AddUpgradablePassiveSkill(Hero hero, SkillTier skillTier)
    {
        var selector =
            new NewUpgradablePassiveSkillSelector(
            new HeroClassSkillSelector(
            new RandomSkillSelector()));

        var input = new SkillSelectorInput(hero, Core.Skills.Skills.UpgradeablePassiveSkillTypes);
        var output = selector.SelectSkill(input);
        var skill = CreateSkillInstance(output.SkillType, skillTier);
        hero.AddSkill(skill);
    }

    private static void AddPassiveSkill(Hero hero, SkillTier skillTier)
    {
        var selector =
            new NewPassiveSkillSelector(
            new HeroClassSkillSelector(
            new RandomSkillSelector()));

        var input = new SkillSelectorInput(hero, Core.Skills.Skills.PassiveSkillTypes);
        var output = selector.SelectSkill(input);
        var skill = CreateSkillInstance(output.SkillType, skillTier);
        hero.AddSkill(skill);
    }

    private static Skill CreateSkillInstance(Type skillType, SkillTier skillTier)
    {
        var skill = (Skill)Activator.CreateInstance(skillType)!;
        skill.Tier = skillTier;

        return skill;
    }
}
