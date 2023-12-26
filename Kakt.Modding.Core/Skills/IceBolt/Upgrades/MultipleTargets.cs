namespace Kakt.Modding.Core.Skills.IceBolt.Upgrades;

public class MultipleTargets : SkillUpgrade<IceBolt>
{
    public MultipleTargets()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Morgana__iceBolt_multipleTargets";
}
