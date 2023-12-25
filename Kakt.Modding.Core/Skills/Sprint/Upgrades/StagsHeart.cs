namespace Kakt.Modding.Core.Skills.Sprint.Upgrades;

public class StagsHeart : SkillUpgrade<Sprint>
{
    public StagsHeart()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_vanguard__sprint_stagsHeart";
}
