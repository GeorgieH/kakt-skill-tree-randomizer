namespace Kakt.Modding.Core.Skills.MeleeExpertise.Upgrades;

public class HeatOfTheBattle : MeleeExpertiseUpgrade
{
    public HeatOfTheBattle()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_champion__meleeExpertise_heatOfthebattle";
}
