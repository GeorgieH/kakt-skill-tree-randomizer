namespace Kakt.Modding.Core.Skills.GlacialStrike.Upgrades;

public class PrimalIce : SkillUpgrade<GlacialStrike>
{
    public PrimalIce()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Morgana__glacialStrike_primalIce";
}
