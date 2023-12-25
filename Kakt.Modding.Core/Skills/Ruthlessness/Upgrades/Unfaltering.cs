namespace Kakt.Modding.Core.Skills.Ruthlessness.Upgrades;

public class Unfaltering : SkillUpgrade<Ruthlessness>
{
    public Unfaltering()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirGawain__ruthlessness_unfaltering";
}
