namespace Kakt.Modding.Core.Skills.FleetFooted.Upgrades;

public class FirstDodge : SkillUpgrade<FleetFooted>
{
    public FirstDodge()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_marksman__fleetFooted_firstDodge";
}
