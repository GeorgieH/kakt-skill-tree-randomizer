using Kakt.Modding.Core.Heroes;

namespace Kakt.Modding.Core.Skills.Dash;

[HeroClassRestriction(HeroClass.Marksman)]
[SkillAttributes(SkillAttributes.Movement)]
public class MarksmanDash : Dash
{
    public override string Name => "Hero_marksman__dash";
}
