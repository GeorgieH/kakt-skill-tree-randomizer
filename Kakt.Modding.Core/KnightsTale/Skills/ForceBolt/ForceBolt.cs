namespace Kakt.Modding.Core.KnightsTale.Skills.ForceBolt;

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
