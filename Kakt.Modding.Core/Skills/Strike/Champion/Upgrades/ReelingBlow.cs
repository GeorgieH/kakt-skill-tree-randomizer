namespace Kakt.Modding.Core.Skills.Strike.Champion.Upgrades;

[CausesEffects(Effects.Vulnerability)]
public class ReelingBlow : SkillUpgrade<ChampionStrike>
{
    public ReelingBlow()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_champion__strike_reelingBlow";
}
