namespace Kakt.Modding.Core.KnightsTale.Skills;

public class SkillUpgrade : ISkill
{
    public SkillUpgrade(SkillUpgradeInfo info)
    {
        Info = info;
        CodeName = info.CodeName;
        Prerequisite = info.Prerequisite;
    }

    public string CodeName { get; set; }
    public string? ConfigurationName { get; set; }
    public int Cost => SkillCosts.One;
    public Effects Effects => Info.Effects;
    public string? IconName { get; set; }
    public Position2D IconPosition { get; set; }
    public SkillUpgradeInfo Info { get; }
    public int LevelLimit { get; set; }
    public string Prerequisite { get; set; }
    public Effects PrerequisiteEffects => Info.PrerequisiteEffects;
    public SkillTier Tier { get; set; }
    public SkillUpgradeType Type => SkillUpgradeType.Mastery;
}
