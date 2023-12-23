namespace Kakt.Modding.Core.Skills.Strike.Champion.Upgrades;

public class ReelingBlow : ChampionStrikeUpgrade
{
    public override int LevelLimit { get; set; } = HeroLevelLimits.Five;
    public override string Name => "Hero_champion__strike_reelingBlow";
}
