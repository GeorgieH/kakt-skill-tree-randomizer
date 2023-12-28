namespace Kakt.Modding.Core.Skills.PoisonedArrow.Upgrades;

public class PoisonBlast : SkillUpgrade<PoisonedArrow>
{
    public PoisonBlast()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_marksman__poisonedBolt_poisonExplosion";
}
