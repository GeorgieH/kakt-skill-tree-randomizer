namespace Kakt.Modding.Core.Skills.BatteringRam.Upgrades;

public class Shatterer : SkillUpgrade<BatteringRam>
{
    public Shatterer()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_defender__batteringRam_shatterer";
}
