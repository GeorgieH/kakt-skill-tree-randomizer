namespace Kakt.Modding.Core.Skills.MasterBleeding.Upgrades;

public class BloodFrenzy : MasterBleedingUpgrade
{
    public BloodFrenzy()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_champion__masterBleeding_bloodFrenzy";
}
