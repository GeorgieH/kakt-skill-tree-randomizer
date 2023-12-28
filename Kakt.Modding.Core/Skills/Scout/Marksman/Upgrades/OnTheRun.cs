namespace Kakt.Modding.Core.Skills.Scout.Marksman.Upgrades;

public class OnTheRun : SkillUpgrade<MarksmanScout>
{
    public OnTheRun()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_marksman__fleetFooted_onTherun";
}
