namespace Kakt.Modding.Core.Skills.Strike.Defender.Upgrades;

public class SweepingStrike : DefenderStrikeUpgrade
{
    public override int LevelLimit { get; set; } = HeroLevelLimits.Ten;
    public override string Name => "Hero_defender__strike_sweepingStrike";
}
