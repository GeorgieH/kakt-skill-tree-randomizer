namespace Kakt.Modding.Core.Skills.RazorArrow.Upgrades;

public class Precision : SkillUpgrade<RazorArrow>
{
    public Precision()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_marksman__razorArrow_precision";
}
