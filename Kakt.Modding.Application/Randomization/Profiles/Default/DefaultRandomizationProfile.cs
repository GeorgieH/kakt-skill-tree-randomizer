using Kakt.Modding.Application.Skills;
using Kakt.Modding.Domain.Heroes;

namespace Kakt.Modding.Application.Randomization.Profiles.Default;

public class DefaultRandomizationProfile : ISkillTreeRandomizer
{
    public DefaultRandomizationProfileFlags Flags { get; set; }
    public DefaultRandomizationProfileSkillPools SkillPools { get; set; }

    public void SetRandomSkillTree(
        Hero hero,
        ISkillRepository skillRepository,
        ISkillUpgradeRepository skillUpgradeRepository,
        IRandomNumberGeneratorService randomNumberGeneratorService)
    {
        var skillTreeRandomizer = new DefaultSkillTreeRandomizer(
            skillRepository, skillUpgradeRepository, randomNumberGeneratorService);
        skillTreeRandomizer.SetRandomSkillTree(hero, this);
    }
}
