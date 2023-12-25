namespace Kakt.Modding.Core.Skills.RainOfArrows.Upgrades;

public class HeavyBolts : SkillUpgrade<RainOfArrows>
{
    public HeavyBolts()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "SirYvain__rainofArrows_heavyBolts";
}
