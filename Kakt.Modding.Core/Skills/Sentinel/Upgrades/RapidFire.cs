namespace Kakt.Modding.Core.Skills.Sentinel.Upgrades;

public class RapidFire : SkillUpgrade<Sentinel>
{
    public RapidFire()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_marksman__sentinel_rapidFire";
}
