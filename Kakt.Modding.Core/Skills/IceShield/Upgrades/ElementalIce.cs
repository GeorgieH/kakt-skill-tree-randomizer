namespace Kakt.Modding.Core.Skills.IceShield.Upgrades;

public class ElementalIce : SkillUpgrade<IceShield>
{
    public ElementalIce()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_sage__iceShield_elementalIce";
}
