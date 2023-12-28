namespace Kakt.Modding.Core.Skills.Sentinel.Upgrades;

public class BroadShot : SkillUpgrade<Sentinel>
{
    public BroadShot()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_marksman__sentinel_broadShot";
}
