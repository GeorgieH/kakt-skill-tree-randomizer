namespace Kakt.Modding.Core.Skills.DrainBlood.Upgrades;

[CausesEffect(Effect.Weakness)]
public class Bloodletting : SkillUpgrade<DrainBlood>
{
    public Bloodletting()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_champion__drainBlood_bloodletting";
}
