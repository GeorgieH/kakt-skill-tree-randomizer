namespace Kakt.Modding.Core.Skills.Charge.Upgrades;

public class SuddenCharge : ChargeUpgrade
{
    public SuddenCharge()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_vanguard__charge_suddenCharge";
}
