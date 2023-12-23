namespace Kakt.Modding.Core.Skills.DefensiveStance.Upgrades;

public abstract class DefensiveStanceUpgrade : SkillUpgrade
{
    public override string Prerequisite => nameof(DefensiveStance);
}
