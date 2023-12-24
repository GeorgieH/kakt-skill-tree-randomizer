namespace Kakt.Modding.Core.Skills.PoisonTrap.Upgrades;

[CausesEffect(Effect.Slow)]
public class ThickCloud : SkillUpgrade<GasTrap>
{
    public ThickCloud()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_vanguard__poisonTrap_thickCloud";
}
