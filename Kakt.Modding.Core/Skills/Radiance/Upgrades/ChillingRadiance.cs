namespace Kakt.Modding.Core.Skills.Radiance.Upgrades;

[CausesEffects(Effects.Chill)]
public class ChillingRadiance : SkillUpgrade<Radiance>
{
    public ChillingRadiance()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirLancelot__radiance_chillingRadiance";
}
