namespace Kakt.Modding.Core.Skills.Strike.Sage.Upgrades;

[RequiresEffects(Effects.Freeze)]
public class Splinter : SkillUpgrade<SageStrike>
{
    public Splinter()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_sage__strike_splinter";
}
