namespace Kakt.Modding.Core.Skills.Hunter.Upgrades;

public class GiantSlayer : SkillUpgrade<Hunter>
{
    public GiantSlayer()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_marksman__hunter_giantSlayer";
}
