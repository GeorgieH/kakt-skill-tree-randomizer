namespace Kakt.Modding.Core.Skills.Strike.Vanguard.Upgrades;

public class RelentlessStrikes : VanguardStrikeUpgrade
{
    public RelentlessStrikes()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_vanguard__strike_relentlessStrikes";
}
