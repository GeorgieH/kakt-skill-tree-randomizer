using Kakt.Modding.Core.Heroes;

namespace Kakt.Modding.Randomization.Skills.Default.Filters;

public partial class HeroClassSkillFilter : ISkillSelector
{
    private readonly ISkillRepository skillRepository;
    private readonly ISkillSelector next;

    public HeroClassSkillFilter(ISkillRepository skillRepository, ISkillSelector next)
    {
        this.skillRepository = skillRepository;
        this.next = next;
    }

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        var skillTypes = input.Hero switch
        {
            Arcanist => this.skillRepository.GetArcanistSkillTypes(),
            Champion => this.skillRepository.GetChampionSkillTypes(),
            Defender => this.skillRepository.GetDefenderSkillTypes(),
            Marksman => this.skillRepository.GetMarksmanSkillTypes(),
            Sage => this.skillRepository.GetSageSkillTypes(),
            Vanguard => this.skillRepository.GetVanguardSkillTypes(),
            _ => throw new NotImplementedException()
        };

        input.SkillTypes = skillTypes;

        return this.next.SelectSkill(input);
    }
}
