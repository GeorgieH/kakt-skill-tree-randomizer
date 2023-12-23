namespace Kakt.Modding.Core.Skills.Strike.Sage.Upgrades;

public class Shredder : SageStrikeUpgrade
{
    public Shredder()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_sage__strike_shredder";
}
