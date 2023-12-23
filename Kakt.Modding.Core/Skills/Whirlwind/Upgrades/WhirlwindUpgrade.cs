namespace Kakt.Modding.Core.Skills.Whirlwind.Upgrades;

public abstract class WhirlwindUpgrade : SkillUpgrade
{
    public override string Prerequisite => nameof(Whirlwind);
}
