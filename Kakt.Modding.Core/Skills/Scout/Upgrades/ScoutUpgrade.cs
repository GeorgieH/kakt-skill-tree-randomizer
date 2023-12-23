namespace Kakt.Modding.Core.Skills.Scout.Upgrades;

public abstract class ScoutUpgrade : SkillUpgrade
{
    public override string Prerequisite => nameof(Scout);
}
