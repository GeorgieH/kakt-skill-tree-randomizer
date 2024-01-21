namespace Kakt.Modding.Core.KnightsTale.Skills.Strike.Vanguard.Upgrades;

public class RelentlessStrikes : StrikeUpgrade
{
    public RelentlessStrikes()
    {
        Name = nameof(RelentlessStrikes);
        CodeName = "Hero_vanguard__strike_relentlessStrikes";
        PrerequisiteEffects = Effects.Bleed;
    }
}
