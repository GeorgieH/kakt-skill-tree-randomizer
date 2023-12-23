namespace Kakt.Modding.Core.Skills.EarthShaker.Upgrades;

public abstract class EarthShakerUpgrade : SkillUpgrade
{
    public override string Prerequisite => nameof(EarthShaker);
}
