namespace Kakt.Modding.Core.Skills.IceShield.Upgrades;

public class GlacialAegis : SkillUpgrade<IceShield>
{
    public GlacialAegis()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_sage__iceShield_glacialAegis";
}
