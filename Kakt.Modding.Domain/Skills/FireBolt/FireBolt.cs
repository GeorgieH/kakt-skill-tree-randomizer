namespace Kakt.Modding.Domain.Skills.FireBolt;

public class FireBolt : ActiveSkill
{
    public FireBolt()
    {
        Name = nameof(FireBolt);
        CodeName = "Merlin__fireBolt";
        ConfigurationName = Name;
        Attributes = SkillAttributes.Ranged | SkillAttributes.Spell | SkillAttributes.Fire;
        Effects = Effects.Burn | Effects.Knockback;
    }
}
