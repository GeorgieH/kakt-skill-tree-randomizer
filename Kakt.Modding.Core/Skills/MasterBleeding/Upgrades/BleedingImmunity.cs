namespace Kakt.Modding.Core.Skills.MasterBleeding.Upgrades;

public class BleedingImmunity : MasterBleedingUpgrade
{
    public BleedingImmunity()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_champion__masterBleeding_bleedingImmunity";
}
