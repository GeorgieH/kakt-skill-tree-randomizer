namespace Kakt.Modding.Core.Skills.Immolation;

[SkillAttributes(SkillAttributes.Melee | SkillAttributes.Fire)]
[CausesEffects(Effects.Burn)]
public class Immolation : ActiveSkill
{
    public override string Name => "SirPercivale__immolation";
}
