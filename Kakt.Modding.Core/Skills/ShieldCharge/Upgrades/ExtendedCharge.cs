namespace Kakt.Modding.Core.Skills.ShieldCharge.Upgrades;

public class ExtendedCharge : SkillUpgrade<ShieldCharge>
{
    public ExtendedCharge()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_defender__shieldCharge_extendedCharge";
}
