namespace Kakt.Modding.Core.Skills.Bless.Upgrades;

public class Guidance : SkillUpgrade<Bless>
{
    public Guidance()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_sage__bless_guidance";
}
