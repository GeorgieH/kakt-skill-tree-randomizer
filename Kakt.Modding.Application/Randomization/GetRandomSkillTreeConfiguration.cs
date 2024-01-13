using Kakt.Modding.Application.Skills;
using Kakt.Modding.Configuration;
using Kakt.Modding.Domain.Heroes;
using Kakt.Modding.Domain.Skills;
using MediatR;

namespace Kakt.Modding.Application.Randomization;

public record GetRandomSkillTreeConfigurationCommand(
    Hero Hero,
    ISkillTreeRandomizer SkillTreeRandomizer) : IRequest;

public class GetRandomSkillTreeConfigurationHandler : IRequestHandler<GetRandomSkillTreeConfigurationCommand>
{
    private readonly ISkillRepository skillRepository;
    private readonly ISkillUpgradeRepository skillUpgradeRepository;
    private readonly IRandomNumberGeneratorService randomNumberGeneratorService;
    private readonly IDocumentRepository documentRepository;
    private readonly ILogger logger;

    public GetRandomSkillTreeConfigurationHandler(
        ISkillRepository skillRepository,
        ISkillUpgradeRepository skillUpgradeRepository,
        IRandomNumberGeneratorService randomNumberGeneratorService,
        IDocumentRepository documentRepository,
        ILogger logger)
    {
        this.skillRepository = skillRepository;
        this.skillUpgradeRepository = skillUpgradeRepository;
        this.randomNumberGeneratorService = randomNumberGeneratorService;
        this.documentRepository = documentRepository;
        this.logger = logger;
    }

    public Task Handle(GetRandomSkillTreeConfigurationCommand request, CancellationToken cancellationToken)
    {
        logger.Log($"Randomizing {request.Hero.GetType().Name}...");

        GenerateRandomSkillTree(request);
        SetSkillTreeConfiguration(request);
        SetHeroConfiguration(request);

        return Task.CompletedTask;
    }

    private void GenerateRandomSkillTree(GetRandomSkillTreeConfigurationCommand request)
    {
        request.SkillTreeRandomizer.SetRandomSkillTree(
            request.Hero, skillRepository, skillUpgradeRepository, randomNumberGeneratorService);
    }

    private void SetSkillTreeConfiguration(GetRandomSkillTreeConfigurationCommand request)
    {
        var skillTreeDocument = this.documentRepository.GetSkillTreeDocument();
        var hero = CfgObjectFactory.Get(request.Hero);
        skillTreeDocument.OverwriteObject(hero.Name, hero);
    }

    private void SetHeroConfiguration(GetRandomSkillTreeConfigurationCommand request)
    {
        var hero = request.Hero;

        if (HeroDoesNotRequireConfiguration(hero))
        {
            return;
        }

        if (hero is Merlin)
        {
            WriteMerlinPresets((Merlin)hero);
            return;
        }

        var document = this.documentRepository.GetHeroDocument(hero);

        foreach (var preset in hero.Presets)
        {
            WritePreset(document, preset);
        }
        if (hero is LadyDindraine
            || hero is SirBalan
            || hero is SirBalin
            || hero is SirKay
            || hero is SirPelleas)
        {
            var starterSkills = hero.SkillTree.StarterSkills.Select(s => s!.Name);
            var property = (CfgProperty)document["Hero"]!["Components"]!["caster"]!["skills"]!;
            property.Value = $"{string.Join(",", starterSkills)},unit__passive,death";
        }

        if (hero is RedKnight)
        {
            var property = (CfgProperty)document["Hero"]!["Components"]!["caster"]!["skills"]!;
            property.Value = $"{hero.SkillTree.TierOneActiveSkillThree!.Name},unit__passive,death";
        }

        if (hero is SirDagonet
            || hero is SirEctor)
        {
            var starterSkills = hero.SkillTree.StarterSkills.Select(s => s!.Name);
            var property = (CfgProperty)document["Hero"]!["Components"]!["caster"]!["skills"]!;
            property.Value = $"{string.Join(",", starterSkills)},Hero_arcanist__passive,death";
        }
    }

    private void WriteMerlinPresets(Merlin merlin)
    {
        var hermitDocument = this.documentRepository.GetHermitDocument();
        var hermitPreset = merlin.Presets[0];
        WritePreset(hermitDocument, hermitPreset);

        var hermitProperty = (CfgProperty)hermitDocument["Hero"]!["Components"]!["caster"]!["Skills"]!;
        var skills = new Skill?[]
        {
            merlin.SkillTree.TierOneActiveSkillOne,
            merlin.SkillTree.TierOneActiveSkillTwo,
            merlin.SkillTree.TierOneActiveSkillThree
        }.Select(s => s!.Name);
        hermitProperty.Value = $"{string.Join(",", skills)},Hero_arcanist__passive,death";

        var merlinDocument = this.documentRepository.GetHeroDocument(merlin);
        var merlinPreset = merlin.Presets[1];
        WritePreset(merlinDocument, merlinPreset);
    }

    private static void WritePreset(CfgDocument document, HeroPreset preset)
    {
        var starterSkills = preset.LearnedSkills
            .Where(s => s is Skill skill && skill.Starter);

        var learnedSkills = preset.LearnedSkills
            .Except(starterSkills)
            .Select(s => s.ConfigurationName);

        var value = string.Join(",", learnedSkills);
        var property = (CfgProperty)document["Hero"]!["Presets"]![preset.Name]!["LearnedSkills"]!;
        property.Value = value;
    }

    private static bool HeroDoesNotRequireConfiguration(Hero hero)
    {
        return hero is SirMordred;
    }
}
