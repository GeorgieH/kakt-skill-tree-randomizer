namespace Kakt.Modding.Core.Skills.LightningCleave.Upgrades;

public class SwiftStrike : SkillUpgrade<LightningCleave>
{
    public SwiftStrike()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "SirMordred__lightningCleave_swiftStrike";
}
