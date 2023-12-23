namespace Kakt.Modding.Core.Skills.FleetFooted.Upgrades;

public class OnTheRun : SkillUpgrade<FleetFooted>
{
    public OnTheRun()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_marksman__fleetFooted_onTherun";
}
