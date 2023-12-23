namespace Kakt.Modding.Core.Skills.Vengeance.Upgrades;

public class Frenzy : VengeanceUpgrade
{
    public Frenzy()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_champion__vengeance_frenzy";
}
