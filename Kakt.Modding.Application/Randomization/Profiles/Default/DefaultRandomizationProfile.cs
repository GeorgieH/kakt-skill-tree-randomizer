using Kakt.Modding.Application.Skills;
using Kakt.Modding.Core.Heroes;

namespace Kakt.Modding.Application.Randomization.Profiles.Default;

public class DefaultRandomizationProfile : ISkillTreeRandomizer
{
    public DefaultRandomizationProfileFlags Flags { get; set; }
    public DefaultRandomizationProfileSkillPools SkillPools { get; set; }

    public void SetRandomSkillTree(Hero hero, ISkillRepository skillRepository)
    {
        var skillTreeRandomizer = new DefaultSkillTreeRandomizer(skillRepository);
        skillTreeRandomizer.SetRandomSkillTree(hero);
    }
}
