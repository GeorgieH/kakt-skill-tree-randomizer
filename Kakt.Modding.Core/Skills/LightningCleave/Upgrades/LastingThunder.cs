namespace Kakt.Modding.Core.Skills.LightningCleave.Upgrades;

public class LastingThunder : SkillUpgrade<LightningCleave>
{
    public LastingThunder()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirMordred__lightningCleave_lastingThunder";
}
