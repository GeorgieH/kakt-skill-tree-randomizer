namespace Kakt.Modding.Core.Skills;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public class SkillAttributesAttribute(SkillAttributes skillAttributes) : Attribute
{
    public SkillAttributes SkillAttributes { get; } = skillAttributes;
}
