namespace Kakt.Modding.Core.Skills.Unyielding.Upgrades;

public class PhysicalResistance : SkillUpgrade<Unyielding>
{
    public PhysicalResistance()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_defender__toughness_physicalResistance";
}
