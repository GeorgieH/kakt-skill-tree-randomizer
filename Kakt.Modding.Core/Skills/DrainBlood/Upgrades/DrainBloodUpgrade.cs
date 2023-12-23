namespace Kakt.Modding.Core.Skills.DrainBlood.Upgrades;

public abstract class DrainBloodUpgrade : SkillUpgrade
{
    public override string Prerequisite => nameof(DrainBlood);
}
