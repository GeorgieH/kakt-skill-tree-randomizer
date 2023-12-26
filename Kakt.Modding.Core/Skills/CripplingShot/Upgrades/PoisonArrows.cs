namespace Kakt.Modding.Core.Skills.CripplingShot.Upgrades;

[CausesEffects(Effects.Poison)]
public class PoisonArrows : SkillUpgrade<CripplingShot>
{
    public PoisonArrows()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "SirDamas__cripplingShot_poisonArrows";
}
