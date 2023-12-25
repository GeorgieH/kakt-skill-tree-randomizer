namespace Kakt.Modding.Core.Skills.DivineFavour.Upgrades;

public class Zeal : SkillUpgrade<DivineFavour>
{
    public Zeal()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "SirGalahad__divineFavour_zeal";
}
