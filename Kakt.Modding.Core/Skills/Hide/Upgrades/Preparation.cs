namespace Kakt.Modding.Core.Skills.Hide.Upgrades;

public class Preparation : SkillUpgrade<Hide>
{
    public Preparation()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_vanguard__hide_preparation";
}
