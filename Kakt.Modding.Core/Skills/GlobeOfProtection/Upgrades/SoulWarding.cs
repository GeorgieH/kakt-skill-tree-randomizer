namespace Kakt.Modding.Core.Skills.GlobeOfProtection.Upgrades;

public class SoulWarding : SkillUpgrade<GlobeOfProtection>
{
    public SoulWarding()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_sage__globeOfprotection_soulWarding";
}
