namespace Kakt.Modding.Core.Skills.Taunt;

[SkillAttributes(SkillAttributes.Support)]
public class ChampionTaunt : Taunt
{
    public ChampionTaunt()
    {
        IconName = "Hero_defender__taunt";
    }

    public override string Name => "Hero_champion__taunt";
}
