namespace Kakt.Modding.Core.Skills.HolyArmour.Upgrades;

public class HallowedChampion : SkillUpgrade<HolyArmour>
{
    public HallowedChampion()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "WhiteKnight__holyArmour_hallowedChampion";
}
