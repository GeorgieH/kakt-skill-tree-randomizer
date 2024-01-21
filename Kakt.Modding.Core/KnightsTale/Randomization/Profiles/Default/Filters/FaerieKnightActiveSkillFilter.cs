using Kakt.Modding.Core.KnightsTale.Heroes;
using Kakt.Modding.Core.KnightsTale.Skills;
using Kakt.Modding.Core.KnightsTale.Skills.FireBolt;
using Kakt.Modding.Core.KnightsTale.Skills.ForceBolt;
using Kakt.Modding.Core.KnightsTale.Skills.IceBolt;
using Kakt.Modding.Core.KnightsTale.Skills.ShadowBolt;

namespace Kakt.Modding.Core.KnightsTale.Randomization.Profiles.Default.Filters;

public class FaerieKnightActiveSkillFilter : ISkillSelector
{
    public static readonly HashSet<SkillInfo> BoltSkills =
    [
        new FireBolt(),
        new ForceBolt(),
        new IceBolt(),
        new ShadowBolt(),
    ];

    private readonly ISkillSelector next;
    private readonly IRandomNumberGeneratorService randomNumberGeneratorService;

    public FaerieKnightActiveSkillFilter(
        ISkillSelector next,
        IRandomNumberGeneratorService randomNumberGeneratorService)
    {
        this.next = next;
        this.randomNumberGeneratorService = randomNumberGeneratorService;
    }

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        var hero = input.Hero;
        var profile = input.Profile;
        var skillNumber = input.SkillNumber;

        if (hero is FaerieKnight)
        {
            if (profile.Flags.FaerieKnightAlwaysGetsTierTwoBoltSkill)
            {
                if (skillNumber == 9)
                {
                    return new SkillSelectorOutput(
                        BoltSkills.Random(randomNumberGeneratorService.GetRandom()));
                }
            }
        }

        return next.SelectSkill(input);
    }
}
