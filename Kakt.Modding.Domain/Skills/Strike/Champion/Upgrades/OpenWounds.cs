namespace Kakt.Modding.Domain.Skills.Strike.Champion.Upgrades;

public class OpenWounds : SkillUpgrade
{
    public OpenWounds()
    {
        Name = nameof(OpenWounds);
        CodeName = "Hero_champion__strike_openWounds";
        Effects = Effects.Bleed;
    }
}
