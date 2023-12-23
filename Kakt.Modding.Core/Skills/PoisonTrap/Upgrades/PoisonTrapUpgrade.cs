namespace Kakt.Modding.Core.Skills.PoisonTrap.Upgrades;

public abstract class PoisonTrapUpgrade : SkillUpgrade
{
    public override string Prerequisite => nameof(PoisonTrap);
}
