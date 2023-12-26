namespace Kakt.Modding.Core.Skills.Immolation;

[SkillAttributes(SkillAttributes.Melee | SkillAttributes.Fire)]
[CausesEffect(Effect.Burning)]
public class Immolation : ActiveSkill
{
    public override string Name => "SirPercivale__immolation";
}
