namespace Kakt.Modding.Core.Skills.ThrowingAxe.Upgrades;

[CausesEffects(Effects.Knockdown)]
public class HeavyHanded : SkillUpgrade<ThrowingAxe>
{
    public HeavyHanded()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "RedKnight__throwingAxe_heavyHanded";
}
