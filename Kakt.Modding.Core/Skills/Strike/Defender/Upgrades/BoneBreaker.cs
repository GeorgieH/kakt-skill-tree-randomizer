namespace Kakt.Modding.Core.Skills.Strike.Defender.Upgrades;

public class BoneBreaker : SkillUpgrade<DefenderStrike>
{
    public BoneBreaker()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_defender__strike_bonebreaker";
}
