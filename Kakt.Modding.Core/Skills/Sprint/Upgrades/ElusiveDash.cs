namespace Kakt.Modding.Core.Skills.Sprint.Upgrades;

public class ElusiveDash : SkillUpgrade<Sprint>
{
    public ElusiveDash()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_vanguard__sprint_elusiveDash";
}
