namespace Kakt.Modding.Core.Skills.Strike.Vanguard.Upgrades;

public class FinishingBlow : VanguardStrikeUpgrade
{
    public FinishingBlow()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_vanguard__strike_finishingBlow";
}
