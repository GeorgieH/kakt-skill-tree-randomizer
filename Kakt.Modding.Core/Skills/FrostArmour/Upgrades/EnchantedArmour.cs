namespace Kakt.Modding.Core.Skills.FrostArmour.Upgrades;

public class EnchantedArmour : SkillUpgrade<FrostArmour>
{
    public EnchantedArmour()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_sage__frostArmour_enchantedArmour";
}
