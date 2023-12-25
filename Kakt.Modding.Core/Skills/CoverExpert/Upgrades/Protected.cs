namespace Kakt.Modding.Core.Skills.CoverExpert.Upgrades;

public class Protected : SkillUpgrade<CoverExpert>
{
    public Protected()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_marksman__coverExpert_protected";
}
