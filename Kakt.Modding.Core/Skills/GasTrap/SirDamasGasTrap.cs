namespace Kakt.Modding.Core.Skills.GasTrap;

[SkillUpgradeType(typeof(GasTrap))]
public class SirDamasGasTrap : GasTrap
{
    public SirDamasGasTrap()
    {
        CasterName = "Hero_vanguard__poisonTrap";
        IconName = "Hero_vanguard__poisonTrap";
    }

    public override string Name => "SirDamas__poisonTrap";
}
