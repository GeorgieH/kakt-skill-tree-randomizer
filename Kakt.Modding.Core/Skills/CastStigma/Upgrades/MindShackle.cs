namespace Kakt.Modding.Core.Skills.CastStigma.Upgrades;

public class MindShackle : SkillUpgrade<CastStigma>
{
    public MindShackle()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirMordred__castStigma_mindShackle";
}
