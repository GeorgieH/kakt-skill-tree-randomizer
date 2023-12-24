namespace Kakt.Modding.Core.Skills.MasterOfFire;

[ConfigurationElement("MasterofFire")]
[RequiresEffect(Effect.Burning)]
public class MasterOfFire : UpgradablePassiveSkill
{
    public override string Name => "Hero_arcanist__masterofFire";
}
