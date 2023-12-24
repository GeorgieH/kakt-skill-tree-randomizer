namespace Kakt.Modding.Core.Skills;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public class RequiresSkillAttributeAttribute(SkillAttributes skillAttributes) : Attribute
{
    public SkillAttributes SkillAttributes { get; } = skillAttributes;
}
