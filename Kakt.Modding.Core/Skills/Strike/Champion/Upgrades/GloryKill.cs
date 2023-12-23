namespace Kakt.Modding.Core.Skills.Strike.Champion.Upgrades;

public class GloryKill : ChampionStrikeUpgrade
{
    public override int LevelLimit { get; set; } = HeroLevelLimits.Ten;
    public override string Name => "Hero_champion__strike_gloryKill";
}
