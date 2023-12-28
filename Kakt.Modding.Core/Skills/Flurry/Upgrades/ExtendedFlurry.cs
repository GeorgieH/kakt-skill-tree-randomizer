namespace Kakt.Modding.Core.Skills.Flurry.Upgrades;

public class ExtendedFlurry : SkillUpgrade<Flurry>
{
    public ExtendedFlurry()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_defender__flurry_extendedFlurry";
}
