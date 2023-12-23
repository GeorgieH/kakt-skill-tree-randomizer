namespace Kakt.Modding.Core.Skills.Cleave.Upgrades;

public class Momentum : CleaveUpgrade
{
    public override int LevelLimit { get; set; } = HeroLevelLimits.Five;
    public override string Name => "Hero_champion__cleave_momentum";
}
