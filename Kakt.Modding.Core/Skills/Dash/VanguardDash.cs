using Kakt.Modding.Core.Heroes;

namespace Kakt.Modding.Core.Skills.Dash;

[HeroClassRestriction(HeroClass.Arcanist)]
[HeroClassRestriction(HeroClass.Champion)]
[HeroClassRestriction(HeroClass.Defender)]
[HeroClassRestriction(HeroClass.Sage)]
[HeroClassRestriction(HeroClass.Vanguard)]
[SkillAttributes(SkillAttributes.Movement)]
public class VanguardDash : Dash
{
    public VanguardDash()
    {
        IconName = "Hero_marksman__dash";
    }

    public override string Name => "Hero_vanguard__dash";
}
