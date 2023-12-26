namespace Kakt.Modding.Core.Skills.IceThorns.Upgrades;

public class ElementalIce : SkillUpgrade<IceThorns>
{
    public ElementalIce()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Morgana__iceThorns_elementalIce";
}
