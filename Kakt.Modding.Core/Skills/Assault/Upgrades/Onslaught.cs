namespace Kakt.Modding.Core.Skills.Assault.Upgrades;

public class Onslaught : SkillUpgrade<Assault>
{
    public Onslaught()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "SirLancelot__assault_onslaught";
}
