namespace Kakt.Modding.Core.Skills.ThrowingDagger.Upgrades;

public class PoisonedDagger : ThrowingDaggerUpgrade
{
    public PoisonedDagger()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_vanguard__throwingDagger_poisonedDagger";
}
