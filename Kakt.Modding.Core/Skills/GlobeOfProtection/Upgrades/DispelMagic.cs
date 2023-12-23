namespace Kakt.Modding.Core.Skills.GlobeOfProtection.Upgrades;

public class DispelMagic : SkillUpgrade<GlobeOfProtection>
{
    public DispelMagic()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_sage__globeOfprotection_dispelMagic";
}
