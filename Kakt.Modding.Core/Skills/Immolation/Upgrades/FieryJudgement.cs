namespace Kakt.Modding.Core.Skills.Immolation.Upgrades;

public class FieryJudgement : SkillUpgrade<Immolation>
{
    public FieryJudgement()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirPercivale__immolation_fieryJudgement";
}
