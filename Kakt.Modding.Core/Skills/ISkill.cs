namespace Kakt.Modding.Core.Skills;

public interface ISkill
{
    string? IconName { get; set; }
    string Name { get; }
    string GetNameOrOverride();
    void OverrideName(string nameOverride);
}
