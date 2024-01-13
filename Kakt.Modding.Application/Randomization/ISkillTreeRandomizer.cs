using Kakt.Modding.Application.Skills;
using Kakt.Modding.Domain.Heroes;

namespace Kakt.Modding.Application.Randomization;

public interface ISkillTreeRandomizer
{
    void SetRandomSkillTree(
        Hero hero,
        ISkillRepository skillRepository,
        ISkillUpgradeRepository skillUpgradeRepository,
        IRandomNumberGeneratorService randomNumberGeneratorService);
}
