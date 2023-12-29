namespace Kakt.Modding.Core.Skills.PoisonBomb;

[SkillUpgradeType(typeof(PoisonBomb))]
public class LadyBoudiceaPoisonBomb : PoisonBomb
{
    public LadyBoudiceaPoisonBomb()
    {
        CasterName = "Hero_marksman__poisonBomb";
        IconName = "Hero_marksman__poisonBomb";
    }

    public override string Name => "LadyBoudicea__poisonBomb";
}
