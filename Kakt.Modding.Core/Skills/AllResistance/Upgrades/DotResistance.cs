namespace Kakt.Modding.Core.Skills.AllResistance.Upgrades;

public class DotResistance : SkillUpgrade<AllResistance>
{
    public DotResistance()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_defender__dotResistance";
}
