namespace Kakt.Modding.Core.Skills.Fog.Upgrades;

public class FogWalker : SkillUpgrade<Fog>
{
    public FogWalker()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_arcanist__fog_fogwalker";
}
