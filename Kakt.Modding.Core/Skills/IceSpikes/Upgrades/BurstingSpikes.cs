namespace Kakt.Modding.Core.Skills.IceSpikes.Upgrades;

public class BurstingSpikes : SkillUpgrade<IceSpikes>
{
    public BurstingSpikes()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_sage__iceSpikes_burstingSpikes";
}
