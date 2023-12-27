namespace Kakt.Modding.Core.Skills.DeathStrike;

[SkillUpgradeType(typeof(DeathStrike))]
public class RedKnightDeathStrike : DeathStrike
{
    public RedKnightDeathStrike()
    {
        IconName = "SirKay__deathStrike";
    }

    public override string Name => "RedKnight__deathStrike";
}
