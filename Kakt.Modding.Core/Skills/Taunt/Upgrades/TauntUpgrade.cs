namespace Kakt.Modding.Core.Skills.Taunt.Upgrades;

public abstract class TauntUpgrade : SkillUpgrade
{
    public override string Prerequisite => nameof(Taunt);
}
