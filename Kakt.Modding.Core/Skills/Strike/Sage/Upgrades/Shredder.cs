namespace Kakt.Modding.Core.Skills.Strike.Sage.Upgrades;

public class Shredder : SkillUpgrade<SageStrike>
{
    public Shredder()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_sage__strike_shredder";
}
