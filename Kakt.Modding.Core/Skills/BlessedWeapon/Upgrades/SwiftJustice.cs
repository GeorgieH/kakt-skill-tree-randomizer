namespace Kakt.Modding.Core.Skills.BlessedWeapon.Upgrades;

public class SwiftJustice : SkillUpgrade<BlessedWeapon>
{
    public SwiftJustice()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "WhiteKnight__blessedWeapon_swiftJustice";
}
