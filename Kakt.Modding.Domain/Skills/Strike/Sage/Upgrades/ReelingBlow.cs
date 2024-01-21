namespace Kakt.Modding.Domain.Skills.Strike.Sage.Upgrades;

public class ReelingBlow : StrikeUpgrade
{
    public ReelingBlow()
    {
        Name = nameof(ReelingBlow);
        CodeName = "Hero_sage__strike_reelingBlow";
        Effects = Effects.Vulnerability;
    }
}
