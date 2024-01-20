namespace Kakt.Modding.Core.KnightsTale.Skills.IceBolt;

public class IceBolt : ActiveSkill
{
    public IceBolt()
    {
        Name = nameof(IceBolt);
        CodeName = "Morgana__iceBolt";
        ConfigurationName = Name;
        Attributes = SkillAttributes.Ranged | SkillAttributes.Ice | SkillAttributes.Spell;
        Effects = Effects.Chill;
    }
}
