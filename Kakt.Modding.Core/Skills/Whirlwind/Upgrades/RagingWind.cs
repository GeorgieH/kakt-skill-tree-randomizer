namespace Kakt.Modding.Core.Skills.Whirlwind.Upgrades;

public class RagingWind : SkillUpgrade<Whirlwind>
{
    public RagingWind()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_champion__whirlwind_ragingWind";
}
