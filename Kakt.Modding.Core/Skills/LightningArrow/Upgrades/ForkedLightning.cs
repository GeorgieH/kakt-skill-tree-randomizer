namespace Kakt.Modding.Core.Skills.LightningArrow.Upgrades;

public class ForkedLightning : SkillUpgrade<LightningArrow>
{
    public ForkedLightning()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirGeraint__lightningArrow_forkedLightning";
}
