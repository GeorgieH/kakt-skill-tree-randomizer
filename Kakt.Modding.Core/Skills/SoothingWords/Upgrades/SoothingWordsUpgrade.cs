namespace Kakt.Modding.Core.Skills.SoothingWords.Upgrades;

public abstract class SoothingWordsUpgrade : SkillUpgrade
{
    public override string Prerequisite => nameof(SoothingWords);
}
