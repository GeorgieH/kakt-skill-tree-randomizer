namespace Kakt.Modding.Core.Skills.Strike.Defender.Upgrades;

public class SweepingStrike : SkillUpgrade<DefenderStrike>
{
    public SweepingStrike()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_defender__strike_sweepingStrike";
}
