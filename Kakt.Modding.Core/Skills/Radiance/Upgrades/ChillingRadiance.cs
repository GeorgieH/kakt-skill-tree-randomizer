namespace Kakt.Modding.Core.Skills.Radiance.Upgrades;

[CausesEffect(Effect.Chill)]
public class ChillingRadiance : SkillUpgrade<Radiance>
{
    public ChillingRadiance()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirLancelot__radiance_chillingRadiance";
}
