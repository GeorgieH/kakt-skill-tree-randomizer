namespace Kakt.Modding.Core.Skills.LightningArrow.Upgrades;

public class Thundershot : SkillUpgrade<LightningArrow>
{
    public Thundershot()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "SirGeraint__lightningArrow_thundershot";
}
