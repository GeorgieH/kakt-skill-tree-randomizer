namespace Kakt.Modding.Core.Skills.PurgingStrike.Upgrades;

public class KillingBlow : SkillUpgrade<PurgingStrike>
{
    public KillingBlow()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_Sage__purgingStrike_killingBlow";
}
