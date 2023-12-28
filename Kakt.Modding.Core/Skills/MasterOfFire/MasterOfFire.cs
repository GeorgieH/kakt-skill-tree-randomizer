namespace Kakt.Modding.Core.Skills.MasterOfFire;

[ConfigurationElement("MasterofFire")]
[RequiresEffects(Effects.Burn)]
public class MasterOfFire : UpgradablePassiveSkill
{
    public override string Name => "Hero_arcanist__masterofFire";
}
