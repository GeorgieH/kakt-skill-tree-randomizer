namespace Kakt.Modding.Core.Skills.Preparedness.Upgrades;

public class Retribution : SkillUpgrade<Preparedness>
{
    public Retribution()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "SirKay__preparedness_retribution";
}
