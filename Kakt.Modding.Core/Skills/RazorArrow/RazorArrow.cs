namespace Kakt.Modding.Core.Skills.RazorArrow;

[SkillAttributes(SkillAttributes.Ranged)]
[CausesEffect(Effect.Bleeding)]
public class RazorArrow : ActiveSkill
{
    public override string Name => "Hero_marksman__razorArrow";
}
