namespace Kakt.Modding.Core.Skills.ShieldBlock.Upgrades;

public class StalwartDefender : SkillUpgrade<ShieldBlock>
{
    public StalwartDefender()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_defender__shieldBlock_stalwartDefender";
}
