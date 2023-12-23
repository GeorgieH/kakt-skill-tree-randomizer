namespace Kakt.Modding.Core.Skills;

public abstract class SkillUpgrade
{
    public int Cost => 1;
    public Position2D IconPosition { get; set; }
    public virtual int LevelLimit { get; set; }
    public abstract string Name { get; }
    public abstract string Prerequisite { get; }
    public virtual int Tier { get; set; }
    public SkillUpgradeType Type => SkillUpgradeType.Mastery;
}
