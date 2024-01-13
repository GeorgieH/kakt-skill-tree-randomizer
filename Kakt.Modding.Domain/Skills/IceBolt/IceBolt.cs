namespace Kakt.Modding.Domain.Skills.IceBolt;

public class IceBolt : Skill
{
    public IceBolt()
    {
        Name = nameof(IceBolt);
        CodeName = "Morgana__iceBolt";
        ConfigurationName = Name;
        Type = SkillType.Active;
        Attributes = SkillAttributes.Ranged | SkillAttributes.Ice | SkillAttributes.Spell;
        Effects = Effects.Chill;
    }
}
