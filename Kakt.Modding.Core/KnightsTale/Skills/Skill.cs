namespace Kakt.Modding.Core.KnightsTale.Skills;

public class Skill : ISkill
{
    public Skill(SkillInfo info)
    {
        Info = info;
        CodeName = info.CodeName;
        ConfigurationName = info.ConfigurationName;
        IconName = info.IconName;
    }

    public SkillAttributes Attributes => Info.Attributes;
    public string CodeName { get; set; }
    public string? ConfigurationName { get; set; }
    public int Cost => SkillCosts.Two;
    public Effects Effects => Info.Effects;
    public string? IconName { get; set; }
    public Position2D IconPosition { get; set; }
    public SkillInfo Info { get; }
    public string Name => Info.Name;
    public bool Starter { get; set; }
    public SkillTier Tier { get; set; }
    public SkillType Type => Info.Type;
    public bool Upgradable => Info.Upgradable;
    public List<SkillUpgrade> Upgrades { get; } = [];
}
