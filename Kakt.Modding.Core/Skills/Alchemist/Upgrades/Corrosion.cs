namespace Kakt.Modding.Core.Skills.Alchemist.Upgrades;

public class Corrosion : SkillUpgrade<Alchemist>
{
    public Corrosion()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_marksman__alchemist_corrosion";
}
