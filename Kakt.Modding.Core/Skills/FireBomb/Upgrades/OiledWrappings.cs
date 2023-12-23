namespace Kakt.Modding.Core.Skills.FireBomb.Upgrades;

public class OiledWrappings : SkillUpgrade<FireBomb>
{
    public OiledWrappings()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_marksman__fireBomb_oiledWrappings";
}
