namespace Kakt.Modding.Core.Skills.MarkTarget.Upgrades;

public class Deadeye : SkillUpgrade<MarkTarget>
{
    public Deadeye()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_marksman__markTarget_deadeye";
}
