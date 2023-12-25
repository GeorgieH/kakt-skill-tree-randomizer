namespace Kakt.Modding.Core.Skills.TrueAim.Upgrades;

[CausesEffect(Effect.Weakness)]
public class Advantageous : SkillUpgrade<TrueAim>
{
    public Advantageous()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirYvain__trueAim_advantageous";
}
