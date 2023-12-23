namespace Kakt.Modding.Core.Skills.Strike.Defender.Upgrades;

public class BoneBreaker : DefenderStrikeUpgrade
{
    public BoneBreaker()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_defender__strike_bonebreaker";
}
