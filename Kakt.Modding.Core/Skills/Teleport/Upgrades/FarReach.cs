namespace Kakt.Modding.Core.Skills.Teleport.Upgrades;

public class FarReach : SkillUpgrade<Teleport>
{
    public FarReach()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_sage__teleport_farReach";
}
