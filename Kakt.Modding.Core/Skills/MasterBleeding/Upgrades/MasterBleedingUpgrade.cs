namespace Kakt.Modding.Core.Skills.MasterBleeding.Upgrades;

public abstract class MasterBleedingUpgrade : SkillUpgrade
{
    public override string Prerequisite => nameof(MasterBleeding);
}
