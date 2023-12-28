namespace Kakt.Modding.Core.Skills.Fog.Upgrades;

public class PersistentFog : SkillUpgrade<Fog>
{
    public PersistentFog()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_arcanist__fog_persistentFog";
}
