namespace Kakt.Modding.Core.Skills.Strike.Sage.Upgrades;

public class DrainingStrike : SkillUpgrade<SageStrike>
{
    public DrainingStrike()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_sage__strike_drainingStrike";
}
