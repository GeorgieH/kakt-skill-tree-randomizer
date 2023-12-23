namespace Kakt.Modding.Core.Skills.Inspire.Upgrades;

public class MotivateSelf : SkillUpgrade<Inspire>
{
    public MotivateSelf()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_sage__inspire_motivateSelf";
}
