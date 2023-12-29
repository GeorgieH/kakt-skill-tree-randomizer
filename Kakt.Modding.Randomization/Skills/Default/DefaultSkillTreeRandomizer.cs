using Kakt.Modding.Core.Heroes;
using Kakt.Modding.Core.Skills;
using Kakt.Modding.Core.Skills.FireBolt;
using Kakt.Modding.Core.Skills.FlamingStrike;
using Kakt.Modding.Core.Skills.ForceBolt;
using Kakt.Modding.Core.Skills.IceBolt;
using Kakt.Modding.Core.Skills.LightningStrike;
using Kakt.Modding.Core.Skills.PoisonCut;
using Kakt.Modding.Core.Skills.ShadowBolt;
using Kakt.Modding.Core.Skills.Shoot;
using Kakt.Modding.Core.Skills.Strike;
using Kakt.Modding.Core.Skills.Strike.Champion;
using Kakt.Modding.Core.Skills.Strike.Defender;
using Kakt.Modding.Core.Skills.Strike.Sage;
using Kakt.Modding.Core.Skills.Strike.Vanguard;
using Kakt.Modding.Randomization.Skills.Default.Filters;
using Kakt.Modding.Randomization.Skills.Default.Validators;

namespace Kakt.Modding.Randomization.Skills.Default;

public partial class DefaultSkillTreeRandomizer
{
    private readonly ILogger logger;

    private ISkillRepository skillRepository;

    public DefaultSkillTreeRandomizer(ILogger logger)
    {
        this.logger = logger;
    }

    public IEnumerable<Hero> Generate(DefaultRandomizationProfile profile)
    {
        skillRepository = InitializeSkillRepository(profile);

        var heroes = Heroes.GetAll();

        foreach (var hero in heroes)
        {
            logger.Log($"Randomizing {hero.GetType().Name}...");

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

            AcquireSkills(hero, profile);
        }

        return heroes;
    }

    private ISkillRepository InitializeSkillRepository(DefaultRandomizationProfile profile)
    {
        logger.Log("Initializing skills profile...");

        var repository = new SkillRepository();

        AddSkillTypes(profile.SkillTree.Common, repository.AddCommonSkillType);
        AddSkillTypes(profile.SkillTree.Arcanist, repository.AddArcanistSkillType);
        AddSkillTypes(profile.SkillTree.Champion, repository.AddChampionSkillType);
        AddSkillTypes(profile.SkillTree.Defender, repository.AddDefenderSkillType);
        AddSkillTypes(profile.SkillTree.Marksman, repository.AddMarksmanSkillType);
        AddSkillTypes(profile.SkillTree.Sage, repository.AddSageSkillType);
        AddSkillTypes(profile.SkillTree.Vanguard, repository.AddVanguardSkillType);

        return repository;
    }

    private static void AddSkillTypes(IEnumerable<string> skills, Action<Type> add)
    {
        foreach (var skill in skills)
        {
            var skillType = Core.Skills.Skills
                .GetAllTypes()
                .FirstOrDefault(s => s.Name == skill);

            if (skillType == default)
            {
                throw new InvalidSkillTypeException(skill);
            }

            add(skillType);
        }
    }

    private static ActiveSkill GetBasicAttack(Hero hero)
    {
        Skill skill;

        if (hero is FaerieKnight)
        {
            skill = new LightningStrike();
        }
        else if (hero is LadyMorganaLeFay)
        {
            skill = new IceBolt();
        }
        else if (hero is Merlin)
        {
            skill = new FireBolt();
        }
        else if (hero is SirDagonet)
        {
            skill = new ShadowBolt();
        }
        else if (hero is SirEctor)
        {
            skill = new ForceBolt();
        }
        else if (hero is SirMordred)
        {
            skill = new SirMordredStrike();
        }
        else if (hero is SirGalahad || hero is SirPercival)
        {
            skill = new FlamingStrike();
        }
        else if (hero is SirTristan)
        {
            skill = new PoisonCut();
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

        SkillFactory.Build(skill, SkillTier.One, 1, starter: true);

        return (ActiveSkill)skill;
    }

    private ActiveSkill GetActiveSkill(
        Hero hero, SkillTier skillTier, int skillNumber, DefaultRandomizationProfile profile, bool starter = false)
    {
        var skillSelector =
            new HeroClassSkillFilter(skillRepository,
            new ActiveSkillFilter(
            new RandomSkillSelector()));

        var input = new SkillSelectorInput(hero, skillTier, skillNumber, profile);
        var skill = GetSkill<ActiveSkill>(input, skillSelector);
        SkillFactory.Build(skill, skillTier, skillNumber, starter);

        return skill;
    }

    private UpgradablePassiveSkill GetUpgradablePassiveSkill(
        Hero hero, SkillTier skillTier, int skillNumber, DefaultRandomizationProfile profile)
    {
        var skillSelector =
                new HeroClassSkillFilter(skillRepository,
                new UpgradablePassiveSkillFilter(
                new OncePerSkillTreeValidator(
                new OncePerSkillTierValidator(
                new SkillAttributeValidator(
                new EffectValidator(
                new ArmourerValidator(
                new RandomSkillSelector())))))));

        var input = new SkillSelectorInput(hero, skillTier, skillNumber, profile);
        var skill = GetSkill<UpgradablePassiveSkill>(input, skillSelector);
        SkillFactory.Build(skill, skillTier, skillNumber);

        return skill;
    }

    private PassiveSkill GetPassiveSkill(
        Hero hero, SkillTier skillTier, int skillNumber, DefaultRandomizationProfile profile)
    {
        var skillSelector =
            new HeroClassSkillFilter(skillRepository,
            new PassiveSkillFilter(
            new OncePerSkillTreeValidator(
            new OncePerSkillTierValidator(
            new SkillAttributeValidator(
            new EffectValidator(
            new ArmourerValidator(
            new RandomSkillSelector())))))));

        var input = new SkillSelectorInput(hero, skillTier, skillNumber, profile);
        var skill = GetSkill<PassiveSkill>(input, skillSelector);
        SkillFactory.Build(skill, skillTier, skillNumber, hasUpgrades: false);

        return skill;
    }

    private static T GetSkill<T>(SkillSelectorInput input, ISkillSelector skillSelector) where T : Skill
    {
        T skill;

        try
        {
            var output = skillSelector.SelectSkill(input);
            skill = (T)Activator.CreateInstance(output.SkillType)!;
        }
        catch (InvalidSkillSelectionException ex)
        {
            var excludedSkillTypes = input.ExcludedSkillTypes;
            excludedSkillTypes.Add(ex.SkillType);

            input = new SkillSelectorInput(input.Hero, input.SkillTier, input.SkillNumber, input.Profile)
            {
                ExcludedSkillTypes = excludedSkillTypes
            };

            skill = GetSkill<T>(input, skillSelector);
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

    private static void AcquireSkills(Hero hero, DefaultRandomizationProfile profile)
    {
        var distributer = new RandomSkillPointDistributer(profile);
        distributer.Distribute(hero);
    }
}
