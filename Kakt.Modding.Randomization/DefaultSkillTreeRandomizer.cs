using Kakt.Modding.Core.Heroes;
using Kakt.Modding.Core.Skills;
using Kakt.Modding.Core.Skills.Strike.Champion;

namespace Kakt.Modding.Randomization;

public class DefaultSkillTreeRandomizer
{
    private static readonly Random random = new();

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

        if (hero.Class == HeroClass.Champion)
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
        var skillType = Skills
            .ActiveSkillTypes
            .Except(hero.Skills.Where(s => s is ActiveSkill).Select(s => s.GetType()))
            .Random(random);

        var skill = (Skill)Activator.CreateInstance(skillType)!;
        skill.Starter = starter;
        skill.Tier = skillTier;
        hero.AddSkill(skill);
    }

    private static void AddUpgradablePassiveSkill(Hero hero, SkillTier skillTier)
    {
        var skillType = Skills.UpgradeablePassiveSkillTypes.Random(random);

        var skill = (Skill)Activator.CreateInstance(skillType)!;
        skill.Tier = skillTier;
        hero.AddSkill(skill);
    }

    private static void AddPassiveSkill(Hero hero, SkillTier skillTier)
    {
        var skillType = Skills.PassiveSkillTypes.Random(random);

        var skill = (Skill)Activator.CreateInstance(skillType)!;
        skill.Tier = skillTier;
        hero.AddSkill(skill);
    }
}
