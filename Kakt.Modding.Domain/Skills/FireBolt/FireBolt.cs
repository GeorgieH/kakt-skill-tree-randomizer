namespace Kakt.Modding.Domain.Skills.FireBolt;

public class FireBolt : Skill
{
    public FireBolt()
    {
        Name = nameof(FireBolt);
        CodeName = "Merlin__fireBolt";
        ConfigurationName = Name;
        Type = SkillType.Active;
        Attributes = SkillAttributes.Ranged | SkillAttributes.Spell | SkillAttributes.Fire;
        Effects = Effects.Burn | Effects.Knockback;
    }
}
