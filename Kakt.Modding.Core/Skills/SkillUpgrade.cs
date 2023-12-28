namespace Kakt.Modding.Core.Skills;

public abstract class SkillUpgrade : ISkill
{
    private string? nameOverride;
    private string? prerequisiteOverride;

    public string ConfigurationName { get; set; }
    public int Cost => SkillCosts.One;
    public string? IconName { get; set; }
    public Position2D IconPosition { get; set; }
    public int LevelLimit { get; set; }
    public abstract string Name { get; }
    public abstract string Prerequisite { get; }
    public SkillTier Tier { get; set; }
    public SkillUpgradeType Type => SkillUpgradeType.Mastery;

    public string GetNameOrOverride()
    {
        return string.IsNullOrWhiteSpace(nameOverride) ? Name : nameOverride;
    }

    public string GetPrerequisiteOrOverride()
    {
        return string.IsNullOrWhiteSpace(prerequisiteOverride) ? Prerequisite : prerequisiteOverride;
    }

    public void OverrideName(string nameOverride)
    {
        this.nameOverride = nameOverride;
    }

    public void OverridePrerequisite(string prerequisiteOverride)
    {
        this.prerequisiteOverride = prerequisiteOverride;
    }
}
