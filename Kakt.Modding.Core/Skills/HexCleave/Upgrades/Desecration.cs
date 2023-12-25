namespace Kakt.Modding.Core.Skills.HexCleave.Upgrades;

public class Desecration : SkillUpgrade<HexCleave>
{
    public Desecration()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "BlackKnight__hexCleave_desecration";
}
