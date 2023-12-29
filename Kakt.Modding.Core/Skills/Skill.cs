namespace Kakt.Modding.Core.Skills;

public abstract class Skill : ISkill
{
    private string? nameOverride;

    public string ConfigurationName { get; set; }
    public int Cost { get; set; } = SkillCosts.Two;
    public string? IconName { get; set; }
    public Position2D IconPosition { get; set; }
    public abstract string Name { get; }
    public bool Starter { get; set; }
    public SkillTier Tier { get; set; }
    public abstract SkillType Type { get; }
    public List<SkillUpgrade> Upgrades { get; } = [];

    protected string? CasterName { get; set; }

    public string GetCasterName()
    {
        return string.IsNullOrWhiteSpace(CasterName) ? Name : CasterName;
    }

    public string GetNameOrOverride()
    {
        return string.IsNullOrWhiteSpace(nameOverride) ? Name : nameOverride;
    }

    public void OverrideName(string nameOverride)
    {
        this.nameOverride = nameOverride;
    }
}
