namespace Kakt.Modding.Core.Skills.Whirlwind.Upgrades;

public class Bladestorm : SkillUpgrade<Whirlwind>
{
    public Bladestorm()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_champion__whirlwind_bladestorm";
}
