namespace Kakt.Modding.Core.Skills.Recuperate.Upgrades;

public class Benediction : SkillUpgrade<Recuperate>
{
    public Benediction()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_defender__recuperate_benediction";
}
