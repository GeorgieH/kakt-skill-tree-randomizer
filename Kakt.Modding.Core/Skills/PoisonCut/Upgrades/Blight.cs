namespace Kakt.Modding.Core.Skills.PoisonCut.Upgrades;

public class Blight : SkillUpgrade<PoisonCut>
{
    public Blight()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirTristan__poisonCut_blight";
}
