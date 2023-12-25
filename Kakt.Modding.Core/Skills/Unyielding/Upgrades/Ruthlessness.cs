namespace Kakt.Modding.Core.Skills.Unyielding.Upgrades;

public class Ruthlessness : SkillUpgrade<Unyielding>
{
    public Ruthlessness()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_defender__toughness_ruthlessness";
}
