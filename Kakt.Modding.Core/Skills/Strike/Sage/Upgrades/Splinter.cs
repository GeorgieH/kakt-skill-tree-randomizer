namespace Kakt.Modding.Core.Skills.Strike.Sage.Upgrades;

public class Splinter : SageStrikeUpgrade
{
    public Splinter()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_sage__strike_splinter";
}
