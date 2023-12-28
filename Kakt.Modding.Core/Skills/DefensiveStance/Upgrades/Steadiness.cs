namespace Kakt.Modding.Core.Skills.DefensiveStance.Upgrades;

public class Steadiness : SkillUpgrade<DefensiveStance>
{
    public Steadiness()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_champion__defensiveStance_steadiness";
}
