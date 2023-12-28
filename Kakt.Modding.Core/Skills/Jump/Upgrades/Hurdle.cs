namespace Kakt.Modding.Core.Skills.Jump.Upgrades;

public class Hurdle : SkillUpgrade<Jump>
{
    public Hurdle()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_vanguard__jump_hurdle";
}
