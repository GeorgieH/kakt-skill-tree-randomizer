namespace Kakt.Modding.Core.Skills.DazingStrikes.Upgrades;

public class StunImmunity : DazingStrikesUpgrade
{
    public StunImmunity()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_champion__dazingStrikes_stunImmunity";
}
