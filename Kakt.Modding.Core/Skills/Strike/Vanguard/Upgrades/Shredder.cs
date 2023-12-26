namespace Kakt.Modding.Core.Skills.Strike.Vanguard.Upgrades;

public class Shredder : VanguardStrikeUpgrade
{
    public Shredder()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_vanguard__strike_shredder";
}
