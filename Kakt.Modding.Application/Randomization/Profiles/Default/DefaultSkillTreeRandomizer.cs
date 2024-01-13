using Kakt.Modding.Application.Randomization.Profiles.Default.Filters;
using Kakt.Modding.Application.Randomization.Profiles.Default.Validators;
using Kakt.Modding.Application.Skills;
using Kakt.Modding.Domain.Heroes;
using Kakt.Modding.Domain.Skills;
using Kakt.Modding.Domain.Skills.FireBolt;
using Kakt.Modding.Domain.Skills.FlamingStrike;
using Kakt.Modding.Domain.Skills.ForceBolt;
using Kakt.Modding.Domain.Skills.IceBolt;
using Kakt.Modding.Domain.Skills.LightningStrike;
using Kakt.Modding.Domain.Skills.PoisonCut;
using Kakt.Modding.Domain.Skills.ShadowBolt;
using Kakt.Modding.Domain.Skills.Shoot;
using Kakt.Modding.Domain.Skills.Strike;
using Kakt.Modding.Domain.Skills.Strike.Champion;
using Kakt.Modding.Domain.Skills.Strike.Defender;
using Kakt.Modding.Domain.Skills.Strike.Sage;
using Kakt.Modding.Domain.Skills.Strike.Vanguard;

namespace Kakt.Modding.Application.Randomization.Profiles.Default;

public class DefaultSkillTreeRandomizer
{
    private readonly ISkillRepository skillRepository;
    private readonly ISkillUpgradeRepository skillUpgradeRepository;
    private readonly IRandomNumberGeneratorService randomNumberGeneratorService;
    private readonly ISkillFactory skillFactory;

    public DefaultSkillTreeRandomizer(
        ISkillRepository skillRepository,
        ISkillUpgradeRepository skillUpgradeRepository,
        IRandomNumberGeneratorService randomNumberGeneratorService)
    {
        this.skillRepository = skillRepository;
        this.skillUpgradeRepository = skillUpgradeRepository;
        this.randomNumberGeneratorService = randomNumberGeneratorService;
        this.skillFactory = new SkillFactory(skillRepository, skillUpgradeRepository, randomNumberGeneratorService);
    }

    public void SetRandomSkillTree(Hero hero, DefaultRandomizationProfile profile)
    {
        var repositoryManager = new SkillRepositoryManager(skillRepository, skillUpgradeRepository);
        repositoryManager.AddBasicSkills();

        hero.SkillTree.TierOneActiveSkillOne = GetBasicAttack(hero);
        hero.SkillTree.TierOneActiveSkillTwo = GetActiveSkill(hero, SkillTier.One, 2, profile);
        hero.SkillTree.TierOneActiveSkillThree = GetActiveSkill(hero, SkillTier.One, 3, profile, starter: true);

        if (hero is Vanguard)
        {
            hero.SkillTree.TierOneActiveSkillFour = GetActiveSkill(hero, SkillTier.One, 4, profile);
        }
        else
        {
            hero.SkillTree.TierOneUpgradablePassiveSkillOne = GetUpgradablePassiveSkill(hero, SkillTier.One, 4, profile);
        }

        hero.SkillTree.TierOnePassiveSkillOne = GetPassiveSkill(hero, SkillTier.One, 5, profile);
        hero.SkillTree.TierOnePassiveSkillTwo = GetPassiveSkill(hero, SkillTier.One, 6, profile);
        hero.SkillTree.TierOnePassiveSkillThree = GetPassiveSkill(hero, SkillTier.One, 7, profile);

        hero.SkillTree.TierTwoActiveSkillOne = GetActiveSkill(hero, SkillTier.Two, 8, profile);
        hero.SkillTree.TierTwoActiveSkillTwo = GetActiveSkill(hero, SkillTier.Two, 9, profile);
        hero.SkillTree.TierTwoActiveSkillThree = GetActiveSkill(hero, SkillTier.Two, 11, profile);
        hero.SkillTree.TierTwoUpgradablePassiveSkillOne = GetUpgradablePassiveSkill(hero, SkillTier.Two, 10, profile);
        hero.SkillTree.TierTwoPassiveSkillOne = GetPassiveSkill(hero, SkillTier.Two, 12, profile);
        hero.SkillTree.TierTwoPassiveSkillTwo = GetPassiveSkill(hero, SkillTier.Two, 13, profile);

        hero.SkillTree.TierThreeActiveSkillOne = GetActiveSkill(hero, SkillTier.Three, 14, profile);
        hero.SkillTree.TierThreeActiveSkillTwo = GetActiveSkill(hero, SkillTier.Three, 17, profile);
        hero.SkillTree.TierThreeUpgradablePassiveSkillOne = GetUpgradablePassiveSkill(hero, SkillTier.Three, 15, profile);
        hero.SkillTree.TierThreeUpgradablePassiveSkillTwo = GetUpgradablePassiveSkill(hero, SkillTier.Three, 16, profile);
        hero.SkillTree.TierThreePassiveSkillOne = GetPassiveSkill(hero, SkillTier.Three, 18, profile);
        hero.SkillTree.TierThreePassiveSkillTwo = GetPassiveSkill(hero, SkillTier.Three, 19, profile);
        hero.SkillTree.TierThreePassiveSkillThree = GetPassiveSkill(hero, SkillTier.Three, 20, profile);

        DeduplicateSkillNames(hero);

        AcquireSkills(hero);
    }

    private Skill GetBasicAttack(Hero hero)
    {
        Type skillType;

        if (hero is FaerieKnight)
        {
            skillType = typeof(LightningStrike);
        }
        else if (hero is LadyMorganaLeFay)
        {
            skillType = typeof(IceBolt);
        }
        else if (hero is Merlin)
        {
            skillType = typeof(FireBolt);
        }
        else if (hero is SirDagonet)
        {
            skillType = typeof(ShadowBolt);
        }
        else if (hero is SirEctor)
        {
            skillType = typeof(ForceBolt);
        }
        else if (hero is SirMordred)
        {
            skillType = typeof(SirMordredStrike);
        }
        else if (hero is SirGalahad || hero is SirPercival)
        {
            skillType = typeof(FlamingStrike);
        }
        else if (hero is SirTristan)
        {
            skillType = typeof(PoisonCut);
        }
        else if (hero is Champion)
        {
            skillType = typeof(ChampionStrike);
        }
        else if (hero is Defender)
        {
            skillType = typeof(DefenderStrike);
        }
        else if (hero is Marksman)
        {
            skillType = typeof(Shoot);
        }
        else if (hero is Sage)
        {
            skillType = typeof(SageStrike);
        }
        else if (hero is Vanguard)
        {
            skillType = typeof(VanguardStrike);
        }
        else
        {
            throw new NotImplementedException();
        }

        return this.skillFactory.Get(skillType, SkillTier.One, 1, starter: true);
    }

    private Skill GetActiveSkill(
        Hero hero, SkillTier skillTier, int skillNumber, DefaultRandomizationProfile profile, bool starter = false)
    {
        var skillSelector =
            new HeroClassSkillFilter(
            new ActiveSkillFilter(
            new RandomSkillSelector()));

        var input = new SkillSelectorInput(
            hero, skillTier, skillNumber, this.skillRepository, this.randomNumberGeneratorService, profile);

        var skill = GetSkill(input, skillSelector);

        return this.skillFactory.Get(skill, skillTier, skillNumber, starter);
    }

    private Skill GetUpgradablePassiveSkill(
        Hero hero, SkillTier skillTier, int skillNumber, DefaultRandomizationProfile profile)
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

        var input = new SkillSelectorInput(
            hero, skillTier, skillNumber, this.skillRepository, this.randomNumberGeneratorService, profile);

        var skill = GetSkill(input, skillSelector);

        return this.skillFactory.Get(skill, skillTier, skillNumber);
    }

    private Skill GetPassiveSkill(
        Hero hero, SkillTier skillTier, int skillNumber, DefaultRandomizationProfile profile)
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

        var input = new SkillSelectorInput(
            hero, skillTier, skillNumber, this.skillRepository, this.randomNumberGeneratorService, profile);

        var skill = GetSkill(input, skillSelector);

        return this.skillFactory.Get(skill, skillTier, skillNumber, hasUpgrades: false);
    }

    private static Skill GetSkill(SkillSelectorInput input, ISkillSelector skillSelector)
    {
        Skill skill;

        try
        {
            var output = skillSelector.SelectSkill(input);
            skill = output.Skill.Copy();
        }
        catch (InvalidSkillSelectionException ex)
        {
            var excludedSkills = input.ExcludedSkills;
            excludedSkills.Add(ex.Skill);

            input = new SkillSelectorInput(
                input.Hero,
                input.SkillTier,
                input.SkillNumber,
                input.SkillRepository,
                input.RandomNumberGeneratorService,
                input.Profile)
            {
                ExcludedSkills = excludedSkills
            };

            skill = GetSkill(input, skillSelector);
        }

        return skill;
    }

    private static void DeduplicateSkillNames(Hero hero)
    {
        var skillRegister = new Dictionary<string, int>();

        void DeduplicateSkillName(ISkill skill)
        {
            var skillName = skill.Name;

            if (skillRegister!.TryGetValue(skillName, out var index))
            {
                var newIndex = index + 1;
                skillRegister[skillName] = newIndex;
                skill.OverrideName($"{skillName}{newIndex}");

                if (string.IsNullOrWhiteSpace(skill.IconName))
                {
                    skill.IconName = skillName;
                }
            }
            else
            {
                skillRegister.Add(skillName, 1);
            }
        }

        foreach (var skill in hero.SkillTree.Skills)
        {
            DeduplicateSkillName(skill!);

            foreach (var skillUpgrade in skill!.Upgrades)
            {
                DeduplicateSkillName(skillUpgrade);
            }
        }
    }

    private void AcquireSkills(Hero hero)
    {
        var distributer = new RandomSkillPointDistributor(this.randomNumberGeneratorService);
        distributer.Distribute(hero);
    }
}
