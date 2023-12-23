namespace Kakt.Modding.Core.Skills.PoisonCut.Upgrades;

public class Blight : PoisonCutUpgrade
{
    public override int LevelLimit { get; set; } = HeroLevelLimits.Ten;
    public override string Name => "SirTristan__poisonCut_blight";
}
