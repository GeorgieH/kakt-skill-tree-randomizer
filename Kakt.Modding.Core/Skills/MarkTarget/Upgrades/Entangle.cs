namespace Kakt.Modding.Core.Skills.MarkTarget.Upgrades;

public class Entangle : SkillUpgrade<MarkTarget>
{
    public Entangle()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_marksman__markTarget_entangle";
}
