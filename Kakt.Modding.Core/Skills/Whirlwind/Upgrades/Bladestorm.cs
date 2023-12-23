namespace Kakt.Modding.Core.Skills.Whirlwind.Upgrades;

public class Bladestorm : WhirlwindUpgrade
{
    public Bladestorm()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_champion__whirlwind_bladestorm";
}
