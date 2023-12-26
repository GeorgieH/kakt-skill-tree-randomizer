namespace Kakt.Modding.Core.Skills.Strike.Champion.Upgrades;

public class GloryKill : SkillUpgrade<ChampionStrike>
{
    public GloryKill()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_champion__strike_gloryKill";
}
