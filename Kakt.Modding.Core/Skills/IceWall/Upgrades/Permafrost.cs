namespace Kakt.Modding.Core.Skills.IceWall.Upgrades;

public class Permafrost : SkillUpgrade<IceWall>
{
    public Permafrost()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_sage__iceWall_permafrost";
}
