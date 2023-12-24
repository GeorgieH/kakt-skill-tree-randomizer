namespace Kakt.Modding.Core.Skills.JumpingAttack.Upgrades;

[CausesEffect(Effect.Knockback)]
[CausesEffect(Effect.Knockdown)]
public class Recoil : SkillUpgrade<JumpingAttack>
{
    public Recoil()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_vanguard__jumpingAttack_recoil";
}
