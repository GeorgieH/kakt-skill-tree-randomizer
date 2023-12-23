namespace Kakt.Modding.Core.Skills.AuraOfProtection.Upgrades;

public class KeenMind : SkillUpgrade<AuraOfProtection>
{
    public KeenMind()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_sage__auraOfprotection_keenMind";
}
