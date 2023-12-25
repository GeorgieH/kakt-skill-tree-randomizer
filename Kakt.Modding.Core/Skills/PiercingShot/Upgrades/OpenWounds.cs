namespace Kakt.Modding.Core.Skills.PiercingShot.Upgrades;

[CausesEffect(Effect.Bleeding)]
public class OpenWounds : SkillUpgrade<PiercingShot>
{
    public OpenWounds()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "SirYvain__piercingShot_quickReload";
}
