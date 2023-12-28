namespace Kakt.Modding.Core.Skills.IceThorns.Upgrades;

public class JaggedThorns : SkillUpgrade<IceThorns>
{
    public JaggedThorns()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Morgana__iceThorns_jaggedThorns";
}
