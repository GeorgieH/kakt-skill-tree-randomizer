namespace Kakt.Modding.Core.Skills.FireBolt.Upgrades;

public class MultipleTargets : SkillUpgrade<FireBolt>
{
    public MultipleTargets()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Merlin__fireBolt_multipleTargets";
}
