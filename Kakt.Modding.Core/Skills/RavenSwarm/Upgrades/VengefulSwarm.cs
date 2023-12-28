namespace Kakt.Modding.Core.Skills.RavenSwarm.Upgrades;

public class VengefulSwarm : SkillUpgrade<RavenSwarm>
{
    public VengefulSwarm()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_arcanist__ravenSwarm_vengefulSwarm";
}
