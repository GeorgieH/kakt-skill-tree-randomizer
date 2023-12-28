namespace Kakt.Modding.Core.Skills.ShieldCharge.Upgrades;

public class Momentum : SkillUpgrade<ShieldCharge>
{
    public Momentum()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_defender__shieldCharge_momentum";
}
