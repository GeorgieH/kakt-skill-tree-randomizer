namespace Kakt.Modding.Core.Skills.Bless.Upgrades;

public class MassBlessing : SkillUpgrade<Bless>
{
    public MassBlessing()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_sage__bless_massBlessing";
}
