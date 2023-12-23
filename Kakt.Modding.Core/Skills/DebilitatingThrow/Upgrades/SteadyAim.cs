namespace Kakt.Modding.Core.Skills.DebilitatingThrow.Upgrades;

public class SteadyAim : DebilitatingThrowUpgrade
{
    public SteadyAim()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_vanguard__debilitatingThrow_steadyAim";
}
