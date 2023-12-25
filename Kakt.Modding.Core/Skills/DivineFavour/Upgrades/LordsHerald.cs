namespace Kakt.Modding.Core.Skills.DivineFavour.Upgrades;

public class LordsHerald : SkillUpgrade<DivineFavour>
{
    public LordsHerald()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirGalahad__divineFavour_lordsHerald";
}
