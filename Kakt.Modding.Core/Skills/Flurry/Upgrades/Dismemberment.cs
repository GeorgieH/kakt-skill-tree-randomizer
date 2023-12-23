namespace Kakt.Modding.Core.Skills.Flurry.Upgrades;

public class Dismemberment : SkillUpgrade<Flurry>
{
    public Dismemberment()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_defender__flurry_dismemberment";
}
