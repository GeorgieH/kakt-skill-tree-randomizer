namespace Kakt.Modding.Core.Skills.Jump.Upgrades;

public class Hurdle : JumpUpgrade
{
    public Hurdle()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_vanguard__jump_hurdle";
}
