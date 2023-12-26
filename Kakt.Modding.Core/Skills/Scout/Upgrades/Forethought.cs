namespace Kakt.Modding.Core.Skills.Scout.Upgrades;

[RequiresSkillAttributes(SkillAttributes.Movement)]
public class Forethought : SkillUpgrade<Scout>
{
    public Forethought()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_vanguard__scout_forethought";
}
