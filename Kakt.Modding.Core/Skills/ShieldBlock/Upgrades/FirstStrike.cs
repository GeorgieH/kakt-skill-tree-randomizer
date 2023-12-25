namespace Kakt.Modding.Core.Skills.ShieldBlock.Upgrades;

public class FirstStrike : SkillUpgrade<ShieldBlock>
{
    public FirstStrike()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_defender__shieldBlock_firstStrike";
}
