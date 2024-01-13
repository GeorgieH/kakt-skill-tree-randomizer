namespace Kakt.Modding.Domain.Skills.ForceBolt;

public class ForceBolt : Skill
{
    public ForceBolt()
    {
        Name = nameof(ForceBolt);
        CodeName = "Hero_arcanist__forceBolt";
        ConfigurationName = Name;
        Type = SkillType.Active;
        Attributes = SkillAttributes.Ranged | SkillAttributes.Spell;
        Effects = Effects.Knockback;
    }
}
