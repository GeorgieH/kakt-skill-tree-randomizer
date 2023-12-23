namespace Kakt.Modding.Core.Skills.JumpingAttack.Upgrades;

public class Recoil : SkillUpgrade<JumpingAttack>
{
    public Recoil()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_vanguard__jumpingAttack_recoil";
}
