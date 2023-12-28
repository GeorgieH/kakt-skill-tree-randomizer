namespace Kakt.Modding.Core.Skills.MassProtection.Upgrades;

public class Cleanse : SkillUpgrade<MassProtection>
{
    public Cleanse()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_sage__massProtection_cleanse";
}
