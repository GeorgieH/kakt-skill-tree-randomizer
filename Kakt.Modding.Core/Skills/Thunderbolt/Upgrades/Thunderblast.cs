namespace Kakt.Modding.Core.Skills.Thunderbolt.Upgrades;

[CausesEffects(Effects.Stun)]
public class Thunderblast : SkillUpgrade<Thunderbolt>
{
    public Thunderblast()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirMordred__thunderbolt_thunderblast";
}
