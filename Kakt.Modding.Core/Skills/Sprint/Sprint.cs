namespace Kakt.Modding.Core.Skills.Sprint;

[SkillAttributes(SkillAttributes.Movement)]
[CausesEffect(Effect.Hidden)]
public class Sprint : ActiveSkill
{
    public override string Name => "Hero_vanguard__sprint";
}
