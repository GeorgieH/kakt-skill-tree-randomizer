namespace Kakt.Modding.Core.Skills.CleansingFire.Upgrades;

public class Rekindle : SkillUpgrade<CleansingFire>
{
    public Rekindle()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_sage__cleansingFire_rekindle";
}
