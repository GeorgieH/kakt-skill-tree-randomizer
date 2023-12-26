namespace Kakt.Modding.Core.Skills.GasTrap;

[ConfigurationElement("PoisonTrap")]
[SkillAttributes(SkillAttributes.Trap)]
[CausesEffects(Effects.Poison)]
public class GasTrap : ActiveSkill
{
    public override string Name => "Hero_vanguard__poisonTrap";
}
