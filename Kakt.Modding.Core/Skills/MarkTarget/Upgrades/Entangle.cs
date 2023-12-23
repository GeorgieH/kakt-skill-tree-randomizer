namespace Kakt.Modding.Core.Skills.MarkTarget.Upgrades;

public class Entangle : MarkTargetUpgrade
{
    public Entangle()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_marksman__markTarget_entangle";
}
