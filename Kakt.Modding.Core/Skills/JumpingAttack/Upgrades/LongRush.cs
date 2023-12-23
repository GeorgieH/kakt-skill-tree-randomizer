namespace Kakt.Modding.Core.Skills.JumpingAttack.Upgrades;

public class LongRush : JumpingAttackUpgrade
{
    public LongRush()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_vanguard__jumpingAttack_longRush";
}
