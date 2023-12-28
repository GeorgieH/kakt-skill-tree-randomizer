namespace Kakt.Modding.Core.Skills.StormOfArrows.Upgrades;

public class Cloudburst : SkillUpgrade<StormOfArrows>
{
    public Cloudburst()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirGeraint__stormofArrows_cloudburst";
}
