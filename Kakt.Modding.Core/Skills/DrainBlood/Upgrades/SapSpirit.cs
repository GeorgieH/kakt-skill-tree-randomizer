namespace Kakt.Modding.Core.Skills.DrainBlood.Upgrades;

public class SapSpirit : DrainBloodUpgrade
{
    public SapSpirit()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_champion__drainBlood_sapSpirit";
}
