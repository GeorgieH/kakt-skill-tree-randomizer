namespace Kakt.Modding.Core.Skills.Assault.Upgrades;

[CausesEffect(Effect.Shock)]
public class ShockingAssault : SkillUpgrade<Assault>
{
    public ShockingAssault()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirLancelot__assault_shockingAssault";
}
