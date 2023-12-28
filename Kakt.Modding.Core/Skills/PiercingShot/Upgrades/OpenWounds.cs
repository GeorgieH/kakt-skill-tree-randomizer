namespace Kakt.Modding.Core.Skills.PiercingShot.Upgrades;

[CausesEffects(Effects.Bleed)]
public class OpenWounds : SkillUpgrade<PiercingShot>
{
    public OpenWounds()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "SirYvain__piercingShot_quickReload";
}
