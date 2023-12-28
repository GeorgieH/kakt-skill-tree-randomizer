namespace Kakt.Modding.Core.Skills.Guard.Upgrades;

public class KnightlyZeal : SkillUpgrade<Guard>
{
    public KnightlyZeal()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_defender__guard_knightlyZeal";
}
