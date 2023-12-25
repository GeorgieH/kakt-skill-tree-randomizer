namespace Kakt.Modding.Core.Skills.StormOfArrows.Upgrades;

public class ShredderArrows : SkillUpgrade<StormOfArrows>
{
    public ShredderArrows()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "SirGeraint__stormofArrows_shredderArrows";
}
