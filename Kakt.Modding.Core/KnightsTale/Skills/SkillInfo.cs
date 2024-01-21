
namespace Kakt.Modding.Core.KnightsTale.Skills;

public class SkillInfo : IEquatable<SkillInfo?>
{
    public string Name { get; set; }
    public string CodeName { get; set; }
    public string? ConfigurationName { get; set; }
    public string? IconName { get; set; }
    public SkillType Type { get; set; }
    public bool Upgradable { get; set; }
    public SkillAttributes Attributes { get; set; }
    public SkillAttributes PrerequisiteAttributes { get; set; }
    public PrerequisiteCheckType PrerequisiteAttributesCheckType { get; set; }
    public Effects Effects { get; set; }
    public Effects PrerequisiteEffects { get; set; }

    public SkillInfo Copy() => new()
    {
        Name = Name,
        CodeName = CodeName,
        ConfigurationName = ConfigurationName,
        IconName = IconName,
        Type = Type,
        Upgradable = Upgradable,
        Attributes = Attributes,
        PrerequisiteAttributes = PrerequisiteAttributes,
        PrerequisiteAttributesCheckType = PrerequisiteAttributesCheckType,
        Effects = Effects,
        PrerequisiteEffects = PrerequisiteEffects
    };

    public override bool Equals(object? obj)
    {
        return Equals(obj as SkillInfo);
    }

    public bool Equals(SkillInfo? other)
    {
        return other is not null &&
               CodeName == other.CodeName;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(CodeName);
    }
}
