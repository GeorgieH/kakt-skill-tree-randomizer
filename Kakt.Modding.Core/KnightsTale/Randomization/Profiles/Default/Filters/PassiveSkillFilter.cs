using Kakt.Modding.Core.KnightsTale.Skills;

namespace Kakt.Modding.Core.KnightsTale.Randomization.Profiles.Default.Filters;

public class PassiveSkillFilter : ISkillSelector
{
    private readonly ISkillSelector next;

    public PassiveSkillFilter(ISkillSelector next)
    {
        this.next = next;
    }

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        var existingUpgradablePassiveSkillTypes = input.Hero.SkillTree.UpgradablePassiveSkills
            .Where(s => s is not null);

        var existingPassiveSkillTypesAtSameTier = input.Hero.SkillTree.PassiveSkills
            .Where(s => s is not null)
            .Where(s => s!.Tier == input.SkillTier);

        var existingSkillTypes = existingUpgradablePassiveSkillTypes
            .Concat(existingPassiveSkillTypesAtSameTier)
            .Select(s => s!.Info);

        input.IncludedSkillInfos = input.IncludedSkillInfos
            .Where(s => s.Type == SkillType.Passive)
            .Except(existingSkillTypes)!;

        return next.SelectSkill(input);
    }
}
