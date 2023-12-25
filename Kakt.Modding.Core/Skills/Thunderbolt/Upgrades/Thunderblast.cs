namespace Kakt.Modding.Core.Skills.Thunderbolt.Upgrades;

[CausesEffect(Effect.Stun)]
public class Thunderblast : SkillUpgrade<Thunderbolt>
{
    public Thunderblast()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirMordred__thunderbolt_thunderblast";
}
