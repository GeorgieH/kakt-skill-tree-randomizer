namespace Kakt.Modding.Core.Skills.RazorArrow.Upgrades;

public class RightInTheKnee : SkillUpgrade<RazorArrow>
{
    public RightInTheKnee()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_marksman__razorArrow_rightintheKnee";
}
