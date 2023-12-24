using Kakt.Modding.Core.Heroes;

namespace Kakt.Modding.Core.Skills.AimedShot;

[HeroClassRestriction(HeroClass.Marksman)]
[SkillAttributes(SkillAttributes.Ranged)]
public class AimedShot : ActiveSkill
{
    public override string Name => "Hero_marksman__aimedShot";
}
