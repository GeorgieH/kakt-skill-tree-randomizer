namespace Kakt.Modding.Core.Skills.Vengeance.Upgrades;

public abstract class VengeanceUpgrade : SkillUpgrade
{
    public override string Prerequisite => nameof(Vengeance);
}
