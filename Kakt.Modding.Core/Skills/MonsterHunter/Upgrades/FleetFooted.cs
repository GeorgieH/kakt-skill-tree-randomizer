namespace Kakt.Modding.Core.Skills.MonsterHunter.Upgrades;

public class FleetFooted : SkillUpgrade<MonsterHunter>
{
    public FleetFooted()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirGawain__monsterHunter_fleetFooted";
}
