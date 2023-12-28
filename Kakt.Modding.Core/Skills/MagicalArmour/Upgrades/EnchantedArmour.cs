namespace Kakt.Modding.Core.Skills.MagicalArmour.Upgrades;

public class EnchantedArmour : SkillUpgrade<MagicalArmour>
{
    public EnchantedArmour()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_arcanist__magicalArmour_enchantedArmour";
}
