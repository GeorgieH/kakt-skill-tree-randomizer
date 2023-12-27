using Kakt.Modding.Core.Heroes;

namespace Kakt.Modding.Randomization.Skills.Default.Filters;

public partial class HeroClassSkillFilter : ISkillSelector
{
    private readonly ISkillSelector next;

    public HeroClassSkillFilter(ISkillSelector next)
    {
        this.next = next;
    }

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        var skillTypes = input.Hero switch
        {
            Arcanist => SkillRepository.GetArcanistSkills(),
            Champion => SkillRepository.GetChampionSkills(),
            Defender => SkillRepository.GetDefenderSkills(),
            Marksman => SkillRepository.GetMarksmanSkills(),
            Sage => SkillRepository.GetSageSkills(),
            Vanguard => SkillRepository.GetVanguardSkills(),
            _ => throw new NotImplementedException()
        };

        input.SkillTypes = skillTypes;

        return this.next.SelectSkill(input);
    }
}
