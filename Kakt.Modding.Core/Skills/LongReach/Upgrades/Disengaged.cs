namespace Kakt.Modding.Core.Skills.LongReach.Upgrades;

public class Disengaged : SkillUpgrade<LongReach>
{
    public Disengaged()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_marksman__longReach_disengaged";
}
