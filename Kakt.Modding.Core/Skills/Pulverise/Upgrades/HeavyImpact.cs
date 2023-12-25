namespace Kakt.Modding.Core.Skills.Pulverise.Upgrades;

[CausesEffect(Effect.Stun)]
public class HeavyImpact : SkillUpgrade<Pulverise>
{
    public HeavyImpact()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_champion__pulverise_heavyImpact";
}
