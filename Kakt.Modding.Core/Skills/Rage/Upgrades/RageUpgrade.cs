namespace Kakt.Modding.Core.Skills.Rage.Upgrades;

public abstract class RageUpgrade : SkillUpgrade
{
    public override string Prerequisite => nameof(Rage);
}
