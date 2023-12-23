namespace Kakt.Modding.Core.Skills.DamageFocus.Upgrades;

public class Readiness : DamageFocusUpgrade
{
    public Readiness()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_champion__damageFocus_readiness";
}
