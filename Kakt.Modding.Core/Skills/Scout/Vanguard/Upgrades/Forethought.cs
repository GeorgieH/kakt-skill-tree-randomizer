namespace Kakt.Modding.Core.Skills.Scout.Vanguard.Upgrades;

[RequiresSkillAttributes(SkillAttributes.Movement)]
public class Forethought : SkillUpgrade<VanguardScout>
{
    public Forethought()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_vanguard__scout_forethought";
}
