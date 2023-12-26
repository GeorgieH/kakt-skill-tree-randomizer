namespace Kakt.Modding.Core.Skills.GasTrap;

[ConfigurationElement("PoisonTrap")]
[SkillAttributes(SkillAttributes.Trap)]
[CausesEffect(Effect.Poison)]
public class GasTrap : ActiveSkill
{
    public override string Name => "Hero_vanguard__poisonTrap";
}
