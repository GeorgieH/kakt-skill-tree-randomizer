namespace Kakt.Modding.Core.Skills.DeathStrike.Upgrades;

public class FastRecovery : DeathStrikeUpgrade
{
    public FastRecovery()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirKay__deathStrike_fastRecovery";
}
