namespace Kakt.Modding.Core.Skills.Shoot.Upgrades;

public class QuickDraw : SkillUpgrade<Shoot>
{
    public QuickDraw()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_marksman__shoot_quickDraw";
}
