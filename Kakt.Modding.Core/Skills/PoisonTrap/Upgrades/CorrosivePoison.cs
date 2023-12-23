namespace Kakt.Modding.Core.Skills.PoisonTrap.Upgrades;

public class CorrosivePoison : PoisonTrapUpgrade
{
    public CorrosivePoison()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_vanguard__poisonTrap_corrosivePoison";
}
