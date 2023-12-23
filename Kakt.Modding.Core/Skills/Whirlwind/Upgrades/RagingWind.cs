namespace Kakt.Modding.Core.Skills.Whirlwind.Upgrades;

public class RagingWind : WhirlwindUpgrade
{
    public RagingWind()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_champion__whirlwind_ragingWind";
}
