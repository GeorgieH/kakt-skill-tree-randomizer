namespace Kakt.Modding.Core.Skills.Kick;

[SkillAttributes(SkillAttributes.Melee)]
[CausesEffect(Effect.Knockback)]
public class Kick : ActiveSkill
{
    public override string Name => "SirKay__kick";
}
