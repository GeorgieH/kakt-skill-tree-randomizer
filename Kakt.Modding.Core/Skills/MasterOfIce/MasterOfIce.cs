namespace Kakt.Modding.Core.Skills.MasterOfIce;

[ConfigurationElement("MasterofIce")]
[RequiresEffect(Effect.Chill | Effect.Frozen)]
public class MasterOfIce : UpgradablePassiveSkill
{
    public override string Name => "Hero_sage__masterOfice";
}
