namespace Kakt.Modding.Core.Skills.DrainLife.Upgrades;

public class Devourer : SkillUpgrade<DrainLife>
{
    public Devourer()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "SirTristan__drainLife_devourer";
}
