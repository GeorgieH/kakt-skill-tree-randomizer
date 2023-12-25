namespace Kakt.Modding.Core.Skills.ChainLightning.Upgrades;

[CausesEffect(Effect.Shock)]
public class ScourgeOfMordred : SkillUpgrade<ChainLightning>
{
    public ScourgeOfMordred()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirMordred__chainLightning_scourgeofMordred";
}
