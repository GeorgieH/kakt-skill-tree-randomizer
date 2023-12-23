namespace Kakt.Modding.Core.Skills.BearTrap.Upgrades;

public abstract class BearTrapUpgrade : SkillUpgrade
{
    public override string Prerequisite => nameof(BearTrap);
}
