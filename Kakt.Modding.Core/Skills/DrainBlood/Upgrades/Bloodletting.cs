namespace Kakt.Modding.Core.Skills.DrainBlood.Upgrades;

public class Bloodletting : DrainBloodUpgrade
{
    public Bloodletting()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_champion__drainBlood_bloodletting";
}
