using Kakt.Modding.Core.KnightsTale.Configuration;
using Kakt.Modding.Core.KnightsTale.Heroes;
using Kakt.Modding.Core.KnightsTale.Skills;

namespace Kakt.Modding.Core.KnightsTale.Randomization.Profiles.Default;

public interface IHeroConfigurationWriter
{
    void WriteConfiguration(Hero hero);
}

public class HeroConfigurationWriter : IHeroConfigurationWriter
{
    private readonly IDocumentRepository documentRepository;

    public HeroConfigurationWriter(IDocumentRepository documentRepository)
    {
        this.documentRepository = documentRepository;
    }

    public void WriteConfiguration(Hero hero)
    {
        if (HeroDoesNotRequireConfiguration(hero))
        {
            return;
        }

        if (hero is Merlin merlin)
        {
            WriteMerlinPresets(merlin);
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
            var starterSkills = hero.SkillTree.StarterSkills.Select(s => s!.CodeName);
            var property = (CfgProperty)document["Hero"]!["Components"]!["caster"]!["skills"]!;
            property.Value = $"{string.Join(",", starterSkills)},unit__passive,death";
        }

        if (hero is RedKnight)
        {
            var property = (CfgProperty)document["Hero"]!["Components"]!["caster"]!["skills"]!;
            property.Value = $"{hero.SkillTree.TierOneActiveSkillThree!.CodeName},unit__passive,death";
        }

        if (hero is SirDagonet
            || hero is SirEctor)
        {
            var starterSkills = hero.SkillTree.StarterSkills.Select(s => s!.CodeName);
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
        var skills = new Skill[]
        {
            merlin.SkillTree.TierOneActiveSkillOne!,
            merlin.SkillTree.TierOneActiveSkillTwo!,
            merlin.SkillTree.TierOneActiveSkillThree!
        }.Select(s => s!.CodeName);
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
