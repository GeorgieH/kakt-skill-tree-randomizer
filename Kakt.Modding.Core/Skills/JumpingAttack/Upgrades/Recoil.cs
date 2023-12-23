namespace Kakt.Modding.Core.Skills.JumpingAttack.Upgrades;

public class Recoil : JumpingAttackUpgrade
{
    public Recoil()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_vanguard__jumpingAttack_recoil";
}
