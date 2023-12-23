namespace Kakt.Modding.Core.Skills.FireBomb.Upgrades;

public class PertubingHit : SkillUpgrade<FireBomb>
{
    public PertubingHit()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_marksman__fireBomb_perturbingHit";
}
