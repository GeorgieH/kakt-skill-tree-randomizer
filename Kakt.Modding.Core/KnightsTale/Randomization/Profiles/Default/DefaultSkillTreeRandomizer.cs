using DryIoc;
using Kakt.Modding.Core.KnightsTale.Heroes;
using Kakt.Modding.Core.KnightsTale.Skills;
using Kakt.Modding.Core.KnightsTale.Skills.FireBolt;
using Kakt.Modding.Core.KnightsTale.Skills.FlamingStrike;
using Kakt.Modding.Core.KnightsTale.Skills.ForceBolt;
using Kakt.Modding.Core.KnightsTale.Skills.IceBolt;
using Kakt.Modding.Core.KnightsTale.Skills.LightningStrike;
using Kakt.Modding.Core.KnightsTale.Skills.PoisonCut;
using Kakt.Modding.Core.KnightsTale.Skills.ShadowBolt;
using Kakt.Modding.Core.KnightsTale.Skills.Shoot;
using Kakt.Modding.Core.KnightsTale.Skills.Strike;
using Kakt.Modding.Core.KnightsTale.Skills.Strike.Champion;
using Kakt.Modding.Core.KnightsTale.Skills.Strike.Defender;
using Kakt.Modding.Core.KnightsTale.Skills.Strike.Sage;
using Kakt.Modding.Core.KnightsTale.Skills.Strike.Vanguard;

namespace Kakt.Modding.Core.KnightsTale.Randomization.Profiles.Default;

public class DefaultSkillTreeRandomizer : ISkillTreeRandomizer<DefaultRandomizationProfile>
{
    private readonly IContainer container;
    private readonly ILogger logger;
    private readonly IHeroRepository heroRepository;
    private readonly ISkillInfoRepository skillInfoRepository;
    private readonly ISkillUpgradeInfoRepository skillUpgradeInfoRepository;
    private readonly ISkillFactory skillFactory;

    public DefaultSkillTreeRandomizer(
        IContainer container,
        ILogger logger,
        IHeroRepository heroRepository,
        ISkillInfoRepository skillInfoRepository,
        ISkillUpgradeInfoRepository skillUpgradeInfoRepository,
        ISkillFactory skillFactory)
    {
        this.container = container;
        this.logger = logger;
        this.heroRepository = heroRepository;
        this.skillInfoRepository = skillInfoRepository;
        this.skillUpgradeInfoRepository = skillUpgradeInfoRepository;
        this.skillFactory = skillFactory;
    }

    public IEnumerable<Hero> Generate(DefaultRandomizationProfile profile)
    {
        var repositoryManager = new SkillRepositoryManager(skillInfoRepository, skillUpgradeInfoRepository);
        repositoryManager.AddBasicSkills();

        var heroes = heroRepository.GetAll();

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
        }

        return heroes;
    }

    private Skill GetBasicAttack(Hero hero)
    {
        SkillInfo skillInfo = hero switch
        {
            FaerieKnight => new LightningStrike(),
            LadyMorganaLeFay => new IceBolt(),
            Merlin => new FireBolt(),
            SirDagonet => new ShadowBolt(),
            SirEctor => new ForceBolt(),
            SirMordred => new SirMordredStrike(),
            SirGalahad or SirPercival => new FlamingStrike(),
            SirTristan => new PoisonCut(),
            Champion => new ChampionStrike(),
            Defender => new DefenderStrike(),
            Marksman => new Shoot(),
            Sage => new SageStrike(),
            Vanguard => new VanguardStrike(),
            _ => throw new NotImplementedException(),
        };

        return this.skillFactory.Get(skillInfo, SkillTier.One, 1, starter: true);
    }

    private Skill GetActiveSkill(
        Hero hero, SkillTier skillTier, int skillNumber, DefaultRandomizationProfile profile, bool starter = false)
    {
        var skillSelector = container.Resolve<ISkillSelector>("Active");
        var input = new SkillSelectorInput(hero, skillTier, skillNumber, profile);
        var skillInfo = GetSkillInfo(input, skillSelector);

        return this.skillFactory.Get(skillInfo, skillTier, skillNumber, starter);
    }

    private Skill GetUpgradablePassiveSkill(
        Hero hero, SkillTier skillTier, int skillNumber, DefaultRandomizationProfile profile)
    {
        var skillSelector = container.Resolve<ISkillSelector>("UpgradablePassive");
        var input = new SkillSelectorInput(hero, skillTier, skillNumber, profile);
        var skillInfo = GetSkillInfo(input, skillSelector);

        return this.skillFactory.Get(skillInfo, skillTier, skillNumber);
    }

    private Skill GetPassiveSkill(
        Hero hero, SkillTier skillTier, int skillNumber, DefaultRandomizationProfile profile)
    {
        var skillSelector = container.Resolve<ISkillSelector>("Passive");
        var input = new SkillSelectorInput(hero, skillTier, skillNumber, profile);
        var skillInfo = GetSkillInfo(input, skillSelector);

        return this.skillFactory.Get(skillInfo, skillTier, skillNumber, hasUpgrades: false);
    }

    private static SkillInfo GetSkillInfo(SkillSelectorInput input, ISkillSelector skillSelector)
    {
        SkillInfo skillInfo;

        try
        {
            var output = skillSelector.SelectSkill(input);
            skillInfo = output.SkillInfo;
        }
        catch (InvalidSkillSelectionException ex)
        {
            var excludedSkills = input.ExcludedSkillInfos;
            excludedSkills.Add(ex.SkillInfo);

            input = new SkillSelectorInput(
                input.Hero,
                input.SkillTier,
                input.SkillNumber,
                input.Profile)
            {
                ExcludedSkillInfos = excludedSkills
            };

            skillInfo = GetSkillInfo(input, skillSelector);
        }

        return skillInfo;
    }
}
