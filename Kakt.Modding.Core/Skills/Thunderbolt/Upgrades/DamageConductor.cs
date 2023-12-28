namespace Kakt.Modding.Core.Skills.Thunderbolt.Upgrades;

public class DamageConductor : SkillUpgrade<Thunderbolt>
{
    public DamageConductor()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "SirMordred__thunderbolt_damageConductor";
}
