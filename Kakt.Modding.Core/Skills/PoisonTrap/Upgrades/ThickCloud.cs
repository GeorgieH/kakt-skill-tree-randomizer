namespace Kakt.Modding.Core.Skills.PoisonTrap.Upgrades;

public class ThickCloud : SkillUpgrade<PoisonTrap>
{
    public ThickCloud()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_vanguard__poisonTrap_thickCloud";
}
