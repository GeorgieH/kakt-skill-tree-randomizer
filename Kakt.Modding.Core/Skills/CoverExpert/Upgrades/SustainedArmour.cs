namespace Kakt.Modding.Core.Skills.CoverExpert.Upgrades;

public class SustainedArmour : SkillUpgrade<CoverExpert>
{
    public SustainedArmour()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_marksman__coverExpert_sustainedArmour";
}
