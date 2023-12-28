namespace Kakt.Modding.Core.Skills.PoisonBomb.Upgrades;

public class AcidBlast : SkillUpgrade<PoisonBomb>
{
    public AcidBlast()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_marksman__poisonBomb_acidBlast";
}
