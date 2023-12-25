namespace Kakt.Modding.Core.Skills.FallingStar.Upgrades;

[CausesEffect(Effect.Knockdown)]
public class Shockwave : SkillUpgrade<FallingStar>
{
    public Shockwave()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_arcanist__fallingStar_shockwave";
}
