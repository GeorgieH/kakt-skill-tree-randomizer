namespace Kakt.Modding.Core.Skills.DelayedBarrage.Upgrades;

public class Bombardment : SkillUpgrade<DelayedBarrage>
{
    public Bombardment()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "SirYvain__delayedBarrage_bombardment";
}
