namespace Kakt.Modding.Core.Skills.Hide.Upgrades;

public class Subtle : SkillUpgrade<Hide>
{
    public Subtle()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_vanguard__hide_subtle";
}
