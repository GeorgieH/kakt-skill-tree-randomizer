namespace Kakt.Modding.Core.Skills.Strike.Sage.Upgrades;

public class Splinter : SageStrikeUpgrade
{
    public override int LevelLimit { get; set; } = HeroLevelLimits.Five;
    public override string Name => "Hero_sage__strike_splinter";
}
