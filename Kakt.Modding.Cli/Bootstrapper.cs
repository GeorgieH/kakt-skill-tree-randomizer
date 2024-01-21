using DryIoc;
using Kakt.Modding.Cli.KnightsTale;
using Kakt.Modding.Core;
using Kakt.Modding.Core.KnightsTale.Heroes;
using Kakt.Modding.Core.KnightsTale.Randomization;
using Kakt.Modding.Core.KnightsTale.Randomization.Profiles.Default;
using Kakt.Modding.Core.KnightsTale.Randomization.Profiles.Default.Filters;
using Kakt.Modding.Core.KnightsTale.Randomization.Profiles.Default.Validators;
using Kakt.Modding.Core.KnightsTale.Skills;

namespace Kakt.Modding.Cli;

internal static class Bootstrapper
{
    public static void Run(IContainer container)
    {
        RegisterDependencies(container);

        var logger = container.Resolve<ILogger>();
        logger.Log("Initializing...");

        var skillInfoFactory = container.Resolve<ISkillInfoFactory>();
        skillInfoFactory.Initialize();
    }

    private static void RegisterDependencies(IContainer container)
    {
        container.Register<IDocumentRepository, DocumentRepository>(Reuse.Singleton);
        container.Register<IFileSystemService, FileSystemService>(Reuse.Singleton);
        container.Register<IHeroConfigurationWriter, HeroConfigurationWriter>(Reuse.Singleton);
        container.Register<IHeroRepository, HeroRepository>(Reuse.Singleton);
        container.Register<ILogger, ConsoleLogger>(Reuse.Singleton);
        container.Register<IRandomizationConfigurationService, RandomizationConfigurationService>(Reuse.Singleton);
        container.Register<IRandomNumberGeneratorService, RandomNumberGeneratorService>(Reuse.Singleton);
        container.Register<IRandomSkillPointDistributor, RandomSkillPointDistributor>(Reuse.Singleton);
        container.Register<ISkillFactory, SkillFactory>(Reuse.Singleton);
        container.Register<ISkillInfoFactory, SkillInfoFactory>(Reuse.Singleton);
        container.Register<ISkillInfoRepository, SkillInfoRepository>(Reuse.Singleton);
        container.Register<ISkillNameDeduplicator, SkillNameDeduplicator>(Reuse.Singleton);
        container.Register<ISkillTreeRandomizer<DefaultRandomizationProfile>, DefaultSkillTreeRandomizer>(Reuse.Singleton);
        container.Register<ISkillUpgradeInfoRepository, SkillUpgradeInfoRepository>(Reuse.Singleton);

        RegisterDefaultRandomizationProfileSkillSelectors(container);

        container.RegisterMany(new[]
            {
                typeof(GenerateRandomSkillTreeConfigurationMessageHandler),
            },
            serviceTypeCondition: Registrator.Interfaces);
    }

    private static void RegisterDefaultRandomizationProfileSkillSelectors(IContainer container)
    {
        // Active
        const string activeKey = "Active";
        container.Register<ISkillSelector, RandomSkillSelector>(serviceKey: activeKey);
        container.Register<ISkillSelector, ActiveSkillFilter>(setup: Setup.DecoratorOf(decorateeServiceKey: activeKey));
        container.Register<ISkillSelector, HeroSkillFilter>(setup: Setup.DecoratorOf(decorateeServiceKey: activeKey));
        container.Register<ISkillSelector, HeroClassSkillFilter>(setup: Setup.DecoratorOf(decorateeServiceKey: activeKey));
        container.Register<ISkillSelector, FaerieKnightActiveSkillFilter>(setup: Setup.DecoratorOf(decorateeServiceKey: activeKey));

        // Upgradable Passive
        const string upgradablePassiveKey = "UpgradablePassive";
        container.Register<ISkillSelector, RandomSkillSelector>(serviceKey: upgradablePassiveKey);
        container.Register<ISkillSelector, ArmourerValidator>(setup: Setup.DecoratorOf(decorateeServiceKey: upgradablePassiveKey));
        container.Register<ISkillSelector, HeroTraitValidator>(setup: Setup.DecoratorOf(decorateeServiceKey: upgradablePassiveKey));
        container.Register<ISkillSelector, EffectValidator>(setup: Setup.DecoratorOf(decorateeServiceKey: upgradablePassiveKey));
        container.Register<ISkillSelector, SkillAttributeValidator>(setup: Setup.DecoratorOf(decorateeServiceKey: upgradablePassiveKey));
        container.Register<ISkillSelector, OncePerSkillTierValidator>(setup: Setup.DecoratorOf(decorateeServiceKey: upgradablePassiveKey));
        container.Register<ISkillSelector, OncePerSkillTreeValidator>(setup: Setup.DecoratorOf(decorateeServiceKey: upgradablePassiveKey));
        container.Register<ISkillSelector, UpgradablePassiveSkillFilter>(setup: Setup.DecoratorOf(decorateeServiceKey: upgradablePassiveKey));
        container.Register<ISkillSelector, HeroSkillFilter>(setup: Setup.DecoratorOf(decorateeServiceKey: upgradablePassiveKey));
        container.Register<ISkillSelector, HeroClassSkillFilter>(setup: Setup.DecoratorOf(decorateeServiceKey: upgradablePassiveKey));

        // Passive
        const string passiveKey = "Passive";
        container.Register<ISkillSelector, RandomSkillSelector>(serviceKey: passiveKey);
        container.Register<ISkillSelector, ArmourerValidator>(setup: Setup.DecoratorOf(decorateeServiceKey: passiveKey));
        container.Register<ISkillSelector, HeroTraitValidator>(setup: Setup.DecoratorOf(decorateeServiceKey: passiveKey));
        container.Register<ISkillSelector, EffectValidator>(setup: Setup.DecoratorOf(decorateeServiceKey: passiveKey));
        container.Register<ISkillSelector, SkillAttributeValidator>(setup: Setup.DecoratorOf(decorateeServiceKey: passiveKey));
        container.Register<ISkillSelector, OncePerSkillTierValidator>(setup: Setup.DecoratorOf(decorateeServiceKey: passiveKey));
        container.Register<ISkillSelector, OncePerSkillTreeValidator>(setup: Setup.DecoratorOf(decorateeServiceKey: passiveKey));
        container.Register<ISkillSelector, PassiveSkillFilter>(setup: Setup.DecoratorOf(decorateeServiceKey: passiveKey));
        container.Register<ISkillSelector, HeroSkillFilter>(setup: Setup.DecoratorOf(decorateeServiceKey: passiveKey));
        container.Register<ISkillSelector, HeroClassSkillFilter>(setup: Setup.DecoratorOf(decorateeServiceKey: passiveKey));
    }
}
