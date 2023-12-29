namespace Kakt.Modding.Core.Skills.CastStigma;

[SkillUpgradeType(typeof(CastStigma))]
public class BlackKnightCastStigma : CastStigma
{
    public BlackKnightCastStigma()
    {
        CasterName = "SirMordred__castStigma";
        IconName = "SirMordred__castStigma";
    }

    public override string Name => "BlackKnight__castStigma";
}
