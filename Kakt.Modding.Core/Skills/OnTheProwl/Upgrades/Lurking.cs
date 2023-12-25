namespace Kakt.Modding.Core.Skills.OnTheProwl.Upgrades;

public class Lurking : SkillUpgrade<OnTheProwl>
{
    public Lurking()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirDamas__ontheProwl_lurking";
}
