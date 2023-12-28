namespace Kakt.Modding.Core.Skills.FreezingAttack.Upgrades;

[CausesEffects(Effects.Chill)]
public class LastingCold : SkillUpgrade<FreezingAttack>
{
    public LastingCold()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_sage__freezingAttack_lastingCold";
}
