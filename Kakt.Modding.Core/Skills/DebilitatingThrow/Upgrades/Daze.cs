namespace Kakt.Modding.Core.Skills.DebilitatingThrow.Upgrades;

public class Daze : SkillUpgrade<DebilitatingThrow>
{
    public Daze()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_vanguard__debilitatingThrow_daze";
}
