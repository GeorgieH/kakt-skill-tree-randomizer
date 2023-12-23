namespace Kakt.Modding.Core.Skills.DrainBlood.Upgrades;

public class Bloodletting : SkillUpgrade<DrainBlood>
{
    public Bloodletting()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_champion__drainBlood_bloodletting";
}
