using Kakt.Modding.Core.Heroes;
using Kakt.Modding.Core.Skills;
using Kakt.Modding.Core.Skills.Dash;
using Kakt.Modding.Core.Skills.FireBolt;
using Kakt.Modding.Core.Skills.FlamingStrike;
using Kakt.Modding.Core.Skills.ForceBolt;
using Kakt.Modding.Core.Skills.Hide;
using Kakt.Modding.Core.Skills.IceBolt;
using Kakt.Modding.Core.Skills.Jump;
using Kakt.Modding.Core.Skills.LightningStrike;
using Kakt.Modding.Core.Skills.PoisonCut;
using Kakt.Modding.Core.Skills.ShadowBolt;
using Kakt.Modding.Core.Skills.Shoot;
using Kakt.Modding.Core.Skills.Sprint;
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
    private static readonly Random BasicArcanistSkillsRng = new();
    private static readonly Random VanguardMovementSkillsRng = new();

    public static readonly List<Type> BasicArcanistSkills =
    [
        typeof(FireBolt),
        typeof(ForceBolt),
        typeof(IceBolt),
        typeof(ShadowBolt)
    ];

    public static readonly List<Type> VanguardMovementSkills =
    [
        typeof(VanguardDash),
        typeof(Jump),
        typeof(Sprint),
    ];

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

            if (hero is Vanguard
                && profile.Flags.VanguardsAlwaysGetTierOneMovementSkill)
            {
                var skillType = VanguardMovementSkills.Random(VanguardMovementSkillsRng);
                var skill = (ActiveSkill)Activator.CreateInstance(skillType)!;
                SkillFactory.Build(skill, SkillTier.One, 2);
                hero.SkillTree.TierOneActiveSkillTwo = skill;
            }
            else
            {
                hero.SkillTree.TierOneActiveSkillTwo = GetActiveSkill(hero, SkillTier.One, 2);
            }

            hero.SkillTree.TierOneActiveSkillThree = GetActiveSkill(hero, SkillTier.One, 3, starter: true);

            if (hero is Vanguard
                && profile.Flags.VanguardsAlwaysGetTierOneHide
                && !hero.SkillTree.Skills.Any(s => s is Hide))
            {
                var hide = new Hide();
                SkillFactory.Build(hide, SkillTier.One, 4);
                hero.SkillTree.TierOneActiveSkillFour = hide;
            }
            else
            {
                hero.SkillTree.TierOneUpgradablePassiveSkillOne = GetUpgradablePassiveSkill(hero, SkillTier.One, 4);
            }

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
        else if (hero is SirMordred)
        {
            skill = new SirMordredStrike();
        }
        else if (hero is SirPercival)
        {
            skill = new FlamingStrike();
        }
        else if (hero is SirTristan)
        {
            skill = new PoisonCut();
        }
        else if (hero is Arcanist)
        {
            var type = BasicArcanistSkills.Random(BasicArcanistSkillsRng);
            skill = (Skill)Activator.CreateInstance(type)!;
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

    private ActiveSkill GetActiveSkill(Hero hero, SkillTier skillTier, int skillNumber, bool starter = false)
    {
        var skillSelector =
            new HeroClassSkillFilter(skillRepository,
            new ActiveSkillFilter(
            new RandomSkillSelector()));

        var input = new SkillSelectorInput(hero, skillTier);
        var skill = GetSkill<ActiveSkill>(hero, skillTier, input, skillSelector);
        SkillFactory.Build(skill, skillTier, skillNumber, starter);

        return skill;
    }

    private UpgradablePassiveSkill GetUpgradablePassiveSkill(Hero hero, SkillTier skillTier, int skillNumber)
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

        var input = new SkillSelectorInput(hero, skillTier);
        var skill = GetSkill<UpgradablePassiveSkill>(hero, skillTier, input, skillSelector);
        SkillFactory.Build(skill, skillTier, skillNumber);

        return skill;
    }

    private PassiveSkill GetPassiveSkill(Hero hero, SkillTier skillTier, int skillNumber)
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

        var input = new SkillSelectorInput(hero, skillTier);
        var skill = GetSkill<PassiveSkill>(hero, skillTier, input, skillSelector);
        SkillFactory.Build(skill, skillTier, skillNumber, hasUpgrades: false);

        return skill;
    }

    private static T GetSkill<T>(Hero hero, SkillTier skillTier, SkillSelectorInput input, ISkillSelector skillSelector) where T : Skill
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

            input = new SkillSelectorInput(hero, skillTier)
            {
                ExcludedSkillTypes = excludedSkillTypes
            };

            skill = GetSkill<T>(hero, skillTier, input, skillSelector);
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
