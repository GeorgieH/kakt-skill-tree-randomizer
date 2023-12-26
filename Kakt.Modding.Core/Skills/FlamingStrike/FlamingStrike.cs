namespace Kakt.Modding.Core.Skills.FlamingStrike;

[SkillAttributes(SkillAttributes.Melee | SkillAttributes.Fire)]
[CausesEffect(Effect.Burning)]
public class FlamingStrike : ActiveSkill
{
    public override string Name => "SirPercivale__flamingStrike";
}
