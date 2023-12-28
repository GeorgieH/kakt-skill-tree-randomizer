namespace Kakt.Modding.Core.Skills.IceSpikes.Upgrades;

public class FrostShards : SkillUpgrade<IceSpikes>
{
    public FrostShards()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_sage__iceSpikes_frostShards";
}
