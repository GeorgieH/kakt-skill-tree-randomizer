namespace Kakt.Modding.Core.Skills.SummonLostKnight.Upgrades;

public class EternalServitude : SkillUpgrade<SummonLostKnight>
{
    public EternalServitude()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_arcanist__summonLostKnight_eternalServitude";
}
