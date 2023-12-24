using Kakt.Modding.Core.Heroes;

namespace Kakt.Modding.Core.Skills.Charge;

[HeroClassRestriction(HeroClass.Vanguard)]
[SkillAttributes(SkillAttributes.Melee)]
public class Charge : ActiveSkill
{
    public override string Name => "Hero_vanguard__charge";
}
