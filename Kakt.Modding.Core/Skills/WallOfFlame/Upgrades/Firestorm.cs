namespace Kakt.Modding.Core.Skills.WallOfFlame.Upgrades;

public class Firestorm : SkillUpgrade<WallOfFlame>
{
    public Firestorm()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_arcanist__wallOfflame_firestorm";
}
