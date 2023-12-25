namespace Kakt.Modding.Core.Skills.FallingStar.Upgrades;

public class CometSwarm : SkillUpgrade<FallingStar>
{
    public CometSwarm()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_arcanist__fallingStar_cometSwarm";
}
