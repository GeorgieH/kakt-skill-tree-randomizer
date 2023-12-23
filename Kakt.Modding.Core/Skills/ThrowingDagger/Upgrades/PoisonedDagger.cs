namespace Kakt.Modding.Core.Skills.ThrowingDagger.Upgrades;

public class PoisonedDagger : SkillUpgrade<ThrowingDagger>
{
    public PoisonedDagger()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_vanguard__throwingDagger_poisonedDagger";
}
