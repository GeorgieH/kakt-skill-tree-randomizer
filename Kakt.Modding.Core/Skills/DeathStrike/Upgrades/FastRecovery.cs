namespace Kakt.Modding.Core.Skills.DeathStrike.Upgrades;

public class FastRecovery : SkillUpgrade<DeathStrike>
{
    public FastRecovery()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirKay__deathStrike_fastRecovery";
}
