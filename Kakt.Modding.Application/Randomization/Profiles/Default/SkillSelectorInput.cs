using Kakt.Modding.Application.Skills;
using Kakt.Modding.Domain.Heroes;
using Kakt.Modding.Domain.Skills;

namespace Kakt.Modding.Application.Randomization.Profiles.Default;

public class SkillSelectorInput(
    Hero hero,
    SkillTier skillTier,
    int skillNumber,
    ISkillRepository skillRepository,
    IRandomNumberGeneratorService randomNumberGeneratorService,
    DefaultRandomizationProfile profile)
{
    public Hero Hero { get; } = hero;
    public SkillTier SkillTier { get; } = skillTier;
    public int SkillNumber { get; } = skillNumber;
    public ISkillRepository SkillRepository { get; } = skillRepository;
    public IRandomNumberGeneratorService RandomNumberGeneratorService { get; } = randomNumberGeneratorService;
    public DefaultRandomizationProfile Profile { get; } = profile;
    public IEnumerable<Skill> IncludedSkills { get; set; } = [];
    public HashSet<Skill> ExcludedSkills { get; set; } = [];
}
