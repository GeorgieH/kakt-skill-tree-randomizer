namespace Kakt.Modding.Core.Skills.RavenSwarm.Upgrades;

public class PersistentFlock : SkillUpgrade<RavenSwarm>
{
    public PersistentFlock()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_arcanist__ravenSwarm_persistentFlock";
}
