namespace Kakt.Modding.Core.Skills.FreezingAttack.Upgrades;

[CausesEffect(Effect.Chill)]
public class LastingCold : SkillUpgrade<FreezingAttack>
{
    public LastingCold()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_sage__freezingAttack_lastingCold";
}
