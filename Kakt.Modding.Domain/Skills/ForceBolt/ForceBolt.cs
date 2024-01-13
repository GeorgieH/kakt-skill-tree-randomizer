namespace Kakt.Modding.Domain.Skills.ForceBolt;

public class ForceBolt : ActiveSkill
{
    public ForceBolt()
    {
        Name = nameof(ForceBolt);
        CodeName = "Hero_arcanist__forceBolt";
        ConfigurationName = Name;
        Attributes = SkillAttributes.Ranged | SkillAttributes.Spell;
        Effects = Effects.Knockback;
    }
}
