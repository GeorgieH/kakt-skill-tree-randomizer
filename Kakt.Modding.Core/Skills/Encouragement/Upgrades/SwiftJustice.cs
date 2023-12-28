namespace Kakt.Modding.Core.Skills.Encouragement.Upgrades;

public class SwiftJustice : SkillUpgrade<Encouragement>
{
    public SwiftJustice()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirPercivale__encouragement_swiftJustice";
}
