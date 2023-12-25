namespace Kakt.Modding.Core.Skills.Berserking.Upgrades;

public class Recklessness : SkillUpgrade<Berserking>
{
    public Recklessness()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_vanguard__berserking_recklessness";
}
