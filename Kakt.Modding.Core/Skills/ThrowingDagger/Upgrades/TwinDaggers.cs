namespace Kakt.Modding.Core.Skills.ThrowingDagger.Upgrades;

public class TwinDaggers : SkillUpgrade<ThrowingDagger>
{
    public TwinDaggers()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_vanguard__throwingDagger_twinDaggers";
}
