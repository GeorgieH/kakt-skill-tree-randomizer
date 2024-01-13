namespace Kakt.Modding.Domain.Skills.Strike.Vanguard.Upgrades;

public class RelentlessStrikes : SkillUpgrade
{
    public RelentlessStrikes()
    {
        Name = nameof(RelentlessStrikes);
        CodeName = "Hero_vanguard__strike_relentlessStrikes";
        PrerequisiteEffects = Effects.Bleed;
    }
}
