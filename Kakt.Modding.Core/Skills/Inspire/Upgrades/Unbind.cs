namespace Kakt.Modding.Core.Skills.Inspire.Upgrades;

public class Unbind : SkillUpgrade<Inspire>
{
    public Unbind()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_sage__inspire_unbind";
}
