namespace Kakt.Modding.Core.Skills.Flurry.Upgrades;

public abstract class FlurryUpgrade : SkillUpgrade
{
    public override string Prerequisite => nameof(Flurry);
}
