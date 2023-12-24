namespace Kakt.Modding.Core.Skills.Strike.Champion.Upgrades;

[CausesEffect(Effect.Vulnerability)]
public class ReelingBlow : ChampionStrikeUpgrade
{
    public ReelingBlow()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_champion__strike_reelingBlow";
}
