namespace Kakt.Modding.Core.Skills.Flurry.Upgrades;

public class ExtendedFlurry : FlurryUpgrade
{
    public ExtendedFlurry()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_defender__flurry_extendedFlurry";
}
