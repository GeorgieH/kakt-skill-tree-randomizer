namespace Kakt.Modding.Core.Skills.DeathHex.Upgrades;

public class Oblivion : SkillUpgrade<DeathHex>
{
    public Oblivion()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_arcanist__deathCurse_oblivion";
}
