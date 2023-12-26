namespace Kakt.Modding.Core.Skills.LeapAttack.Upgrades;

[CausesEffects(Effects.Weakness)]
public class Weaken : SkillUpgrade<LeapAttack>
{
    public Weaken()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "BlackKnight__leapAttack_weaken";
}
