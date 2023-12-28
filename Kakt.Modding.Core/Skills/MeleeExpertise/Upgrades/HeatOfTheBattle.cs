namespace Kakt.Modding.Core.Skills.MeleeExpertise.Upgrades;

public class HeatOfTheBattle : SkillUpgrade<MeleeExpertise>
{
    public HeatOfTheBattle()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_champion__meleeExpertise_heatOfthebattle";
}
