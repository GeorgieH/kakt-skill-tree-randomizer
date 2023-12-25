namespace Kakt.Modding.Core.Skills.Ruthlessness.Upgrades;

public class Resolve : SkillUpgrade<Ruthlessness>
{
    public Resolve()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "SirGawain__ruthlessness_resolve";
}
