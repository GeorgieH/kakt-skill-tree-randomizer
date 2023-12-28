namespace Kakt.Modding.Core.Skills.Surge.Upgrades;

public class Sidestep : SkillUpgrade<Surge>
{
    public Sidestep()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "SirGeraint__surge_sidestep";
}
