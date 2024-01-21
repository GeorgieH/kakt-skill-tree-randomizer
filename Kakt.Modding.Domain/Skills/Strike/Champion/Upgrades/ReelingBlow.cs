namespace Kakt.Modding.Domain.Skills.Strike.Champion.Upgrades;

public class ReelingBlow : StrikeUpgrade
{
    public ReelingBlow()
    {
        Name = nameof(ReelingBlow);
        CodeName = "Hero_champion__strike_reelingBlow";
        Effects = Effects.Vulnerability;
    }
}
