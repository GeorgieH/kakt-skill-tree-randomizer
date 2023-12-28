namespace Kakt.Modding.Core.Skills.Kick.Upgrades;

[CausesEffects(Effects.Knockdown)]
public class Kneebreaker : SkillUpgrade<Kick>
{
    public Kneebreaker()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirKay__kick_kneebreaker";
}
