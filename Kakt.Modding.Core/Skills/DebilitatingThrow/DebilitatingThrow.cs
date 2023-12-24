using Kakt.Modding.Core.Heroes;

namespace Kakt.Modding.Core.Skills.DebilitatingThrow;

[HeroClassRestriction(HeroClass.Vanguard)]
[SkillAttributes(SkillAttributes.Ranged)]
[CausesEffect(Effect.Knockdown)]
public class DebilitatingThrow : ActiveSkill
{
    public override string Name => "Hero_vanguard__debilitatingThrow";
}
