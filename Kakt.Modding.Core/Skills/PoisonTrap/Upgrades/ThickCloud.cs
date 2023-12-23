namespace Kakt.Modding.Core.Skills.PoisonTrap.Upgrades;

public class ThickCloud : PoisonTrapUpgrade
{
    public ThickCloud()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_vanguard__poisonTrap_thickCloud";
}
