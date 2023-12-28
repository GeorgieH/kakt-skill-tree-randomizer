namespace Kakt.Modding.Core.Skills.DazingStrikes.Upgrades;

public class StunImmunity : SkillUpgrade<DazingStrikes>
{
    public StunImmunity()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_champion__dazingStrikes_stunImmunity";
}
