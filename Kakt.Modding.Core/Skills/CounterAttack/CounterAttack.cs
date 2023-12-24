using Kakt.Modding.Core.Heroes;

namespace Kakt.Modding.Core.Skills.CounterAttack;

[HeroClassRestriction(HeroClass.Champion)]
[HeroClassRestriction(HeroClass.Defender)]
[HeroClassRestriction(HeroClass.Sage)]
[HeroClassRestriction(HeroClass.Vanguard)]
public class CounterAttack : PassiveSkill
{
    public override string Name => "Hero_vanguard__counterAttack";
}
