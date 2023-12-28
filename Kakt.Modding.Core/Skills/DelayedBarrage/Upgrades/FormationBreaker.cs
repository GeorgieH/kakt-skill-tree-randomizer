namespace Kakt.Modding.Core.Skills.DelayedBarrage.Upgrades;

[CausesEffects(Effects.Vulnerability)]
public class FormationBreaker : SkillUpgrade<DelayedBarrage>
{
    public FormationBreaker()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirYvain__delayedBarrage_formationBreaker";
}
