namespace Kakt.Modding.Core.Skills.Flurry;

[SkillUpgradeType(typeof(Flurry))]
public class LadyBoudiceaFlurry : Flurry
{
    public LadyBoudiceaFlurry()
    {
        CasterName = "Hero_defender__flurry";
        IconName = "Hero_defender__flurry";
    }

    public override string Name => "LadyBoudicea__flurry";
}
