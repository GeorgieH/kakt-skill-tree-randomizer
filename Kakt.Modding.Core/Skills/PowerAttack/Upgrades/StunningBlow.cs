namespace Kakt.Modding.Core.Skills.PowerAttack.Upgrades;

[CausesEffects(Effects.Stun)]
public class StunningBlow : SkillUpgrade<PowerAttack>
{
    public StunningBlow()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_champion__powerAttack_stunningBlow";
}
