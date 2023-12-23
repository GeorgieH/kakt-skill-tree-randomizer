namespace Kakt.Modding.Core.Skills.Charge.Upgrades;

public abstract class ChargeUpgrade : SkillUpgrade
{
    public override string Prerequisite => nameof(Charge);
}
