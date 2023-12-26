namespace Kakt.Modding.Core.Skills.IceLance.Upgrades;

public class IceJavelin : SkillUpgrade<IceLance>
{
    public IceJavelin()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_sage__iceLance_iceJavelin";
}
