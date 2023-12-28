namespace Kakt.Modding.Core.Skills.BlessedWeapon.Upgrades;

public class ConsecratedBlade : SkillUpgrade<BlessedWeapon>
{
    public ConsecratedBlade()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "WhiteKnight__blessedWeapon_consecratedBlade";
}
