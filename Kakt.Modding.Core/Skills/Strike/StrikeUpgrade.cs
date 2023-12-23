namespace Kakt.Modding.Core.Skills.Strike;

public abstract class StrikeUpgrade : SkillUpgrade
{
    public override string Prerequisite => nameof(Strike);
}
