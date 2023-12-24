namespace Kakt.Modding.Core.Skills.IceSpikes.Upgrades;

[CausesEffect(Effect.Knockback)]
[CausesEffect(Effect.Knockdown)]
public class BurstingSpikes : SkillUpgrade<IceSpikes>
{
    public BurstingSpikes()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_sage__iceSpikes_burstingSpikes";
}
