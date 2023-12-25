namespace Kakt.Modding.Core.Skills.Berserking.Upgrades;

public class Enraged : SkillUpgrade<Berserking>
{
    public Enraged()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_vanguard__berserking_enraged";
}
