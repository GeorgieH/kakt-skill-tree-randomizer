namespace Kakt.Modding.Core.Skills.CripplingShot.Upgrades;

[CausesEffect(Effect.Poison)]
public class PoisonArrows : SkillUpgrade<CripplingShot>
{
    public PoisonArrows()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "SirDamas__cripplingShot_poisonArrows";
}
