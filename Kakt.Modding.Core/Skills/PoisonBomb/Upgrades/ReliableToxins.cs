namespace Kakt.Modding.Core.Skills.PoisonBomb.Upgrades;

public class ReliableToxins : SkillUpgrade<PoisonBomb>
{
    public ReliableToxins()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_marksman__poisonBomb_reliableToxins";
}
