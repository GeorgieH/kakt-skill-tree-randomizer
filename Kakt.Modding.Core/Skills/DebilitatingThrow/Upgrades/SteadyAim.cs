namespace Kakt.Modding.Core.Skills.DebilitatingThrow.Upgrades;

public class SteadyAim : SkillUpgrade<DebilitatingThrow>
{
    public SteadyAim()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_vanguard__debilitatingThrow_steadyAim";
}
