namespace Kakt.Modding.Core.KnightsTale.Skills.Strike.Champion.Upgrades;

public class OpenWounds : StrikeUpgrade
{
    public OpenWounds()
    {
        Name = nameof(OpenWounds);
        CodeName = "Hero_champion__strike_openWounds";
        Effects = Effects.Bleed;
    }
}
