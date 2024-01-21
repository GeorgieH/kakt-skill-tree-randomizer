using DryIoc.Messages;
using Kakt.Modding.Core.KnightsTale.Configuration;
using Kakt.Modding.Core.KnightsTale.Heroes;
using Kakt.Modding.Core.KnightsTale.Randomization.Profiles.Default;

namespace Kakt.Modding.Core.KnightsTale.Randomization;

public class GenerateRandomSkillTreeConfigurationMessage : IMessage<IEnumerable<Hero>>
{
}

public class GenerateRandomSkillTreeConfigurationMessageHandler
    : IMessageHandler<GenerateRandomSkillTreeConfigurationMessage, IEnumerable<Hero>>
{
    private readonly IRandomizationConfigurationService randomizationConfigurationService;
    private readonly ISkillTreeRandomizer<DefaultRandomizationProfile> skillTreeRandomizer;
    private readonly ISkillNameDeduplicator skillNameDeduplicator;
    private readonly IRandomSkillPointDistributor randomSkillPointDistributor;
    private readonly IDocumentRepository documentRepository;
    private readonly IHeroConfigurationWriter heroConfigurationWriter;

    public GenerateRandomSkillTreeConfigurationMessageHandler(
        IRandomizationConfigurationService randomizationConfigurationService,
        ISkillTreeRandomizer<DefaultRandomizationProfile> skillTreeRandomizer,
        ISkillNameDeduplicator skillNameDeduplicator,
        IRandomSkillPointDistributor randomSkillPointDistributor,
        IDocumentRepository documentRepository,
        IHeroConfigurationWriter heroConfigurationWriter)
    {
        this.randomizationConfigurationService = randomizationConfigurationService;
        this.skillTreeRandomizer = skillTreeRandomizer;
        this.skillNameDeduplicator = skillNameDeduplicator;
        this.randomSkillPointDistributor = randomSkillPointDistributor;
        this.documentRepository = documentRepository;
        this.heroConfigurationWriter = heroConfigurationWriter;
    }

    public Task<IEnumerable<Hero>> Handle(
        GenerateRandomSkillTreeConfigurationMessage message, CancellationToken cancellationToken)
    {
        var configuration = randomizationConfigurationService.Get();
        var heroes = skillTreeRandomizer.Generate(configuration.Profiles.Default);

        foreach (var hero in heroes)
        {
            skillNameDeduplicator.DeduplicateSkillNames(hero);
            randomSkillPointDistributor.Distribute(hero);
            SetSkillTreeConfiguration(hero);
            heroConfigurationWriter.WriteConfiguration(hero);
        }

        return Task.FromResult(heroes);
    }

    private void SetSkillTreeConfiguration(Hero hero)
    {
        var skillTreeDocument = documentRepository.GetSkillTreeDocument();
        var obj = CfgObjectFactory.Get(hero);
        skillTreeDocument.OverwriteObject(obj.Name, obj);
    }
}
