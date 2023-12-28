namespace Kakt.Modding.Core.Skills.RavenSwarm;

[SkillAttributes(SkillAttributes.Ranged | SkillAttributes.Spell)]
[CausesEffects(Effects.Slow)]
public class RavenSwarm : ActiveSkill
{
    public override string Name => "Hero_arcanist__ravenSwarm";
}
