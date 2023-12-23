namespace Kakt.Modding.Core.Skills.Strike.Sage.Upgrades;

public class DrainingStrike : SageStrikeUpgrade
{
    public override int LevelLimit { get; set; } = HeroLevelLimits.Ten;
    public override string Name => "Hero_sage__strike_drainingStrike";
}
