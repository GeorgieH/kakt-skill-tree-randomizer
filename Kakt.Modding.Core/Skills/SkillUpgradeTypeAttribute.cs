namespace Kakt.Modding.Core.Skills;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public class SkillUpgradeTypeAttribute(Type skillType) : Attribute
{
    public Type SkillType { get; } = skillType;
}
