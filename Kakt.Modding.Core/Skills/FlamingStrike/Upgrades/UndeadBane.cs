namespace Kakt.Modding.Core.Skills.FlamingStrike.Upgrades;

public class UndeadBane : FlamingStrikeUpgrade
{
    public override int LevelLimit { get; set; } = HeroLevelLimits.Ten;
    public override string Name => "SirPercivale__flamingStrike_undeadbane";
}
