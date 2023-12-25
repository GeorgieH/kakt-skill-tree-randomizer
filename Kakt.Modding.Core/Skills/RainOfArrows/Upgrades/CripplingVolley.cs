namespace Kakt.Modding.Core.Skills.RainOfArrows.Upgrades;

public class CripplingVolley : SkillUpgrade<RainOfArrows>
{
    public CripplingVolley()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirYvain__rainofArrows_cripplingVolley";
}
