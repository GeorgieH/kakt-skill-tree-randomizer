
namespace Kakt.Modding.Core.KnightsTale.Skills;

public class SkillUpgradeInfo : IEquatable<SkillUpgradeInfo?>
{
    public string Name { get; set; }
    public string CodeName { get; set; }
    public Effects Effects { get; set; }
    public Effects PrerequisiteEffects { get; set; }
    public string Prerequisite { get; set; }

    public override bool Equals(object? obj)
    {
        return Equals(obj as SkillUpgradeInfo);
    }

    public bool Equals(SkillUpgradeInfo? other)
    {
        return other is not null &&
               Name == other.Name;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name);
    }
}
