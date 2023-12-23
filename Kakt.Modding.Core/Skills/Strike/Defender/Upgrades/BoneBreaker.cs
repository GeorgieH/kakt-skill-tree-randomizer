namespace Kakt.Modding.Core.Skills.Strike.Defender.Upgrades;

public class BoneBreaker : DefenderStrikeUpgrade
{
    public override int LevelLimit { get; set; } = HeroLevelLimits.Five;
    public override string Name => "Hero_defender__strike_bonebreaker";
}
