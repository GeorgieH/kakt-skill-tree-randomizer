namespace Kakt.Modding.Core.Skills.JumpingAttack.Upgrades;

public class LongRush : SkillUpgrade<JumpingAttack>
{
    public LongRush()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_vanguard__jumpingAttack_longRush";
}
