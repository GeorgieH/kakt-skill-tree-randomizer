namespace Kakt.Modding.Core.Skills.Rage.Upgrades;

public class BloodRage : RageUpgrade
{
    public BloodRage()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_champion__rage_bloodRage";
}
