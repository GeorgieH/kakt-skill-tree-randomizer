namespace Kakt.Modding.Core.Skills.RazorArrow;

[SkillAttributes(SkillAttributes.Ranged)]
[CausesEffects(Effects.Bleed)]
public class RazorArrow : ActiveSkill
{
    public override string Name => "Hero_marksman__razorArrow";
}
