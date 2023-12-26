namespace Kakt.Modding.Core.Skills.Teleport.Upgrades;

[CausesEffects(Effects.Hidden)]
public class ShadowGate : SkillUpgrade<Teleport>
{
    public ShadowGate()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_sage__teleport_shadowGate";
}
