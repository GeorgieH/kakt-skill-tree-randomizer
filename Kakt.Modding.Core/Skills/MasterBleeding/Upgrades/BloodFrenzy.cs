namespace Kakt.Modding.Core.Skills.MasterBleeding.Upgrades;

public class BloodFrenzy : SkillUpgrade<MasterBleeding>
{
    public BloodFrenzy()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_champion__masterBleeding_bloodFrenzy";
}
