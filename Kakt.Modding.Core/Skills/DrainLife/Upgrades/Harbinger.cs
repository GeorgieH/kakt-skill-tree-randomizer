namespace Kakt.Modding.Core.Skills.DrainLife.Upgrades;

public class Harbinger : SkillUpgrade<DrainLife>
{
    public Harbinger()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirTristan__drainLife_harbinger";
}
