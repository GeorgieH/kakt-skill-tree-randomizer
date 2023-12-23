namespace Kakt.Modding.Core.Skills.DeathStrike.Upgrades;

public class Swiftness : SkillUpgrade<DeathStrike>
{
    public Swiftness()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "SirKay__deathStrike_swiftness";
}
