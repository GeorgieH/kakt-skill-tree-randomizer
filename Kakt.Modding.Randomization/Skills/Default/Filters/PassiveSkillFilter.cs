namespace Kakt.Modding.Randomization.Skills.Default.Filters;

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
            .Where(s => s is not null)
            .Select(s => s!.GetType());

        var existingPassiveSkillTypesAtSameTier = input.Hero.SkillTree.PassiveSkills
            .Where(s => s is not null)
            .Where(s => s!.Tier == input.SkillTier)
            .Select(s => s!.GetType());

        var existingSkillTypes = existingUpgradablePassiveSkillTypes.Concat(existingPassiveSkillTypesAtSameTier);

        input.SkillTypes = input.SkillTypes.Except(existingSkillTypes);

        return this.next.SelectSkill(input);
    }
}
