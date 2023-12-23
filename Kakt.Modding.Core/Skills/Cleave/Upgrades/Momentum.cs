namespace Kakt.Modding.Core.Skills.Cleave.Upgrades;

public class Momentum : CleaveUpgrade
{
    public Momentum()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_champion__cleave_momentum";
}
