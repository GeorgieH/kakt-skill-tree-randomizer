namespace Kakt.Modding.Core.Skills.Strike.Vanguard.Upgrades;

public class Shredder : SkillUpgrade<VanguardStrike>
{
    public Shredder()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_vanguard__strike_shredder";
}
