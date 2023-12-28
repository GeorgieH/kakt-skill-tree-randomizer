namespace Kakt.Modding.Core.Skills.MasterBleeding.Upgrades;

public class BleedingImmunity : SkillUpgrade<MasterBleeding>
{
    public BleedingImmunity()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_champion__masterBleeding_bleedingImmunity";
}
