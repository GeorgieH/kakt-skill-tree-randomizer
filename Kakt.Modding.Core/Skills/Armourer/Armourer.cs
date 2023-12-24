using Kakt.Modding.Core.Heroes;

namespace Kakt.Modding.Core.Skills.Armourer;

[HeroClassRestriction(HeroClass.Champion)]
[HeroClassRestriction(HeroClass.Defender)]
public class Armourer : PassiveSkill
{
    public override string Name => "Hero_defender__armorer";
}
