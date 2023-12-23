namespace Kakt.Modding.Core.Skills.Jump.Upgrades;

public class LongJump : JumpUpgrade
{
    public LongJump()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_vanguard__jump_longJump";
}
