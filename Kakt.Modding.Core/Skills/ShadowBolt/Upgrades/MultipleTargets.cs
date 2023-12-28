namespace Kakt.Modding.Core.Skills.ShadowBolt.Upgrades;

public class MultipleTargets : SkillUpgrade<ShadowBolt>
{
    public MultipleTargets()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirDagonet__shadowBolt_multipleTargets";
}
