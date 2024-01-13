namespace Kakt.Modding.Domain.Skills.Strike.Sage.Upgrades;

public class ChillingTouch : SkillUpgrade
{
    public ChillingTouch()
    {
        Name = nameof(ChillingTouch);
        CodeName = "Hero_sage__strike_chillingTouch";
        Effects = Effects.Chill;
    }
}
