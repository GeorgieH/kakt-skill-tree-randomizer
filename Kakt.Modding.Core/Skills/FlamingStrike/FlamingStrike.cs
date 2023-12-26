namespace Kakt.Modding.Core.Skills.FlamingStrike;

[SkillAttributes(SkillAttributes.Melee | SkillAttributes.Fire)]
[CausesEffects(Effects.Burn)]
public class FlamingStrike : ActiveSkill
{
    public override string Name => "SirPercivale__flamingStrike";
}
