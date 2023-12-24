namespace Kakt.Modding.Core.Skills.EarthShaker.Upgrades;

[CausesEffect(Effect.Slow)]
public class Stumble : SkillUpgrade<EarthShaker>
{
    public Stumble()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_champion__earthShaker_stumble";
}
