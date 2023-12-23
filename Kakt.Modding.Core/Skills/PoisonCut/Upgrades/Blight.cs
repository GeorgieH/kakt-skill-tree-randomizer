namespace Kakt.Modding.Core.Skills.PoisonCut.Upgrades;

public class Blight : PoisonCutUpgrade
{
    public Blight()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirTristan__poisonCut_blight";
}
