namespace Kakt.Modding.Core.Skills.GlacialStrike.Upgrades;

[CausesEffects(Effects.Freeze)]
public class AntediluvianRime : SkillUpgrade<GlacialStrike>
{
    public AntediluvianRime()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Morgana__glacialStrike_antediluvianRime";
}
