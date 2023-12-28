namespace Kakt.Modding.Core.Skills.AuraOfProtection.Upgrades;

public class ExtendedAura : SkillUpgrade<AuraOfProtection>
{
    public ExtendedAura()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_sage__auraOfprotection_extendedAura";
}
