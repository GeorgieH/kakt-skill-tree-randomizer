namespace Kakt.Modding.Core.Skills.Recuperate.Upgrades;

public class SteelResolve : SkillUpgrade<Recuperate>
{
    public SteelResolve()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_defender__recuperate_steelResolve";
}
