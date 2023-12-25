namespace Kakt.Modding.Core.Skills.ForceCleave.Upgrades;

public class FlowingCleave : SkillUpgrade<ForceCleave>
{
    public FlowingCleave()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "FaerieKnight__forceCleave_flowingCleave";
}
