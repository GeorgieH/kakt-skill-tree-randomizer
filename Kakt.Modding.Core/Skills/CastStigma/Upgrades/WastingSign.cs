namespace Kakt.Modding.Core.Skills.CastStigma.Upgrades;

public class WastingSign : SkillUpgrade<CastStigma>
{
    public WastingSign()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "SirMordred__castStigma_wastingSign";
}
