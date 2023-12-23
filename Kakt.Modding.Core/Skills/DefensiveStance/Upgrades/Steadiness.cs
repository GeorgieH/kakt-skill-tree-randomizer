namespace Kakt.Modding.Core.Skills.DefensiveStance.Upgrades;

public class Steadiness : DefensiveStanceUpgrade
{
    public override int LevelLimit { get; set; } = HeroLevelLimits.Five;
    public override string Name => "Hero_champion__defensiveStance_steadiness";
}
