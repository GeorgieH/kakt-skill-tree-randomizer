namespace Kakt.Modding.Core.Skills.LongReach.Upgrades;

public class Prepared : SkillUpgrade<LongReach>
{
    public Prepared()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_marksman__longReach_prepared";
}
