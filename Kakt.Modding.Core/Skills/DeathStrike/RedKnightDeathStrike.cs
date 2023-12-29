namespace Kakt.Modding.Core.Skills.DeathStrike;

[SkillUpgradeType(typeof(DeathStrike))]
public class RedKnightDeathStrike : DeathStrike
{
    public RedKnightDeathStrike()
    {
        CasterName = "SirKay__deathStrike";
        IconName = "SirKay__deathStrike";
    }

    public override string Name => "RedKnight__deathStrike";
}
