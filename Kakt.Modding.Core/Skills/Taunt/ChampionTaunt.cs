namespace Kakt.Modding.Core.Skills.Taunt;

[SkillAttributes(SkillAttributes.Support)]
[SkillUpgradeType(typeof(Taunt))]
public class ChampionTaunt : Taunt
{
    public ChampionTaunt()
    {
        CasterName = "Hero_defender__taunt";
        IconName = "Hero_defender__taunt";
    }

    public override string Name => "Hero_champion__taunt";
}
