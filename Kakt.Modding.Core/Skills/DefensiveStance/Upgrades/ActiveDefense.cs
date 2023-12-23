namespace Kakt.Modding.Core.Skills.DefensiveStance.Upgrades;

public class ActiveDefense : DefensiveStanceUpgrade
{
    public override int LevelLimit { get; set; } = HeroLevelLimits.Ten;
    public override string Name => "Hero_champion__defensiveStance_activeDefense";
}
