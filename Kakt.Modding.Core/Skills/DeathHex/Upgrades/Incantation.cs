namespace Kakt.Modding.Core.Skills.DeathHex.Upgrades;

public class Incantation : SkillUpgrade<DeathHex>
{
    public Incantation()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_arcanist__deathCurse_incantation";
}
