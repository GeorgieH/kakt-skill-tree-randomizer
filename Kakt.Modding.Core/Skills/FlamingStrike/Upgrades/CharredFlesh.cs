namespace Kakt.Modding.Core.Skills.FlamingStrike.Upgrades;

public class CharredFlesh : FlamingStrikeUpgrade
{
    public override int LevelLimit { get; set; } = HeroLevelLimits.Five;
    public override string Name => "SirPercivale__flamingStrike_charredFlesh";
}
