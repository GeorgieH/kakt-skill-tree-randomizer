namespace Kakt.Modding.Core.Skills.EarthShaker.Upgrades;

public class EarthSplitter : EarthShakerUpgrade
{
    public EarthSplitter()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_champion__earthShaker_earthSplitter";
}
