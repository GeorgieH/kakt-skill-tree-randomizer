namespace Kakt.Modding.Core.KnightsTale.Skills.Strike.Sage.Upgrades;

public class Splinter : StrikeUpgrade
{
    public Splinter()
    {
        Name = nameof(Splinter);
        CodeName = "Hero_sage__strike_splinter";
        PrerequisiteEffects = Effects.Freeze;
    }
}
