namespace Kakt.Modding.Core.Skills.ThunderStorm.Upgrades;

public class Everstorm : SkillUpgrade<ThunderStorm>
{
    public Everstorm()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_sage__thunderStorm_everstorm";
}
