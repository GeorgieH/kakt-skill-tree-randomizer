namespace Kakt.Modding.Core.Skills.DazingStrikes.Upgrades;

public abstract class DazingStrikesUpgrade : SkillUpgrade
{
    public override string Prerequisite => nameof(DazingStrikes);
}
