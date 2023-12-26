namespace Kakt.Modding.Core.Skills.EarthShaker.Upgrades;

[CausesEffects(Effects.Slow)]
public class Stumble : SkillUpgrade<EarthShaker>
{
    public Stumble()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_champion__earthShaker_stumble";
}
