namespace Kakt.Modding.Core.Skills.WallOfFlame.Upgrades;

public class DarkFlames : SkillUpgrade<WallOfFlame>
{
    public DarkFlames()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_arcanist__wallOfflame_darkFlames";
}
