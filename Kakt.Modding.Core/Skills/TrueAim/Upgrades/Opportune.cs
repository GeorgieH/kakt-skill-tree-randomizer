namespace Kakt.Modding.Core.Skills.TrueAim.Upgrades;

public class Opportune : SkillUpgrade<TrueAim>
{
    public Opportune()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "SirYvain__trueAim_opportune";
}
