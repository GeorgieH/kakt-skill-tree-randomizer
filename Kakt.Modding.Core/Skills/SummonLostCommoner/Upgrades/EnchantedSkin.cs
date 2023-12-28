namespace Kakt.Modding.Core.Skills.SummonLostCommoner.Upgrades;

public class EnchantedSkin : SkillUpgrade<SummonLostCommoner>
{
    public EnchantedSkin()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_arcanist__summonLostCommoner_enchantedSkin";
}
