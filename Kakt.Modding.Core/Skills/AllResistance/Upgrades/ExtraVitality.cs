namespace Kakt.Modding.Core.Skills.AllResistance.Upgrades;

public class ExtraVitality : SkillUpgrade<AllResistance>
{
    public ExtraVitality()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_defender__allResistance_extraVitality";
}
