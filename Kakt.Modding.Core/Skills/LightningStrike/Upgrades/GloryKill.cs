namespace Kakt.Modding.Core.Skills.LightningStrike.Upgrades;

public class GloryKill : SkillUpgrade<LightningStrike>
{
    public GloryKill()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "FaerieKnight__LightningStrike_gloryKill";
}
