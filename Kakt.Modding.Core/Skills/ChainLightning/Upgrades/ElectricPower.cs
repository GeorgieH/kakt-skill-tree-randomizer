namespace Kakt.Modding.Core.Skills.ChainLightning.Upgrades;

public class ElectricPower : SkillUpgrade<ChainLightning>
{
    public ElectricPower()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirMordred__chainLightning_electricPower";
}
