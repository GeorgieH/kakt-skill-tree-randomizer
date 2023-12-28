namespace Kakt.Modding.Core.Skills.MagicalArmour.Upgrades;

public class ExtendedArmour : SkillUpgrade<MagicalArmour>
{
    public ExtendedArmour()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_arcanist__magicalArmour_extendedArmour";
}
