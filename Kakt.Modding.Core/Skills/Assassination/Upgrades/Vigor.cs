namespace Kakt.Modding.Core.Skills.Assassination.Upgrades;

public class Vigor : SkillUpgrade<Assassination>
{
    public Vigor()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_vanguard__assassination_vigor";
}
