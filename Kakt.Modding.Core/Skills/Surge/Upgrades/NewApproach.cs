namespace Kakt.Modding.Core.Skills.Surge.Upgrades;

public class NewApproach : SkillUpgrade<Surge>
{
    public NewApproach()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirGeraint__surge_newApproach";
}
