namespace Kakt.Modding.Core.Skills.ForceBolt.Upgrades;

public class MultipleTargets : SkillUpgrade<ForceBolt>
{
    public MultipleTargets()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_arcanist__forceBolt_multipleTargets";
}
