namespace Kakt.Modding.Core.Skills.EarthShaker.Upgrades;

public class Stumble : EarthShakerUpgrade
{
    public Stumble()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_champion__earthShaker_stumble";
}
