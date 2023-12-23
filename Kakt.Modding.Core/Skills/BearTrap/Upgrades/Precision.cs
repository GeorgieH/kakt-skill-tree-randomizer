namespace Kakt.Modding.Core.Skills.BearTrap.Upgrades;

public class Precision : BearTrapUpgrade
{
    public Precision()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_vanguard__bearTrap_precision";
}
