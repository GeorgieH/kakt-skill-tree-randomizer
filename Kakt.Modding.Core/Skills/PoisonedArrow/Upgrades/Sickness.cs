namespace Kakt.Modding.Core.Skills.PoisonedArrow.Upgrades;

public class Sickness : SkillUpgrade<PoisonedArrow>
{
    public Sickness()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_marksman__poisonedBolt_sickness";
}
