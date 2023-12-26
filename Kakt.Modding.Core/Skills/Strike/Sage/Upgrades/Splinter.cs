namespace Kakt.Modding.Core.Skills.Strike.Sage.Upgrades;

[RequiresEffects(Effects.Freeze)]
public class Splinter : SageStrikeUpgrade
{
    public Splinter()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_sage__strike_splinter";
}
