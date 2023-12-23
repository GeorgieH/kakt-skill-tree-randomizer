namespace Kakt.Modding.Core.Skills.SpellResistance.Upgrades;

public class MentalFort : SkillUpgrade<SpellResistance>
{
    public MentalFort()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_arcanist__mentalGuard_mentalFort";
}
