namespace Kakt.Modding.Core.Skills.DrainBlood;

[SkillAttributes(SkillAttributes.Spell)]
[RequiresEffect(Effect.Bleeding)]
public class DrainBlood : ActiveSkill
{
    public override string Name => "Hero_champion__drainBlood";
}
