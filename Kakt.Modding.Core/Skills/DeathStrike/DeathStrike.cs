using Kakt.Modding.Core.Heroes;

namespace Kakt.Modding.Core.Skills.DeathStrike;

[HeroClassRestriction(HeroClass.Champion)]
[HeroClassRestriction(HeroClass.Defender)]
[HeroClassRestriction(HeroClass.Sage)]
[SkillAttributes(SkillAttributes.Melee)]
public class DeathStrike : ActiveSkill
{
    public override string Name => "SirKay__deathStrike";
}
