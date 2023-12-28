namespace Kakt.Modding.Core.Skills.ForceBolt.Upgrades;

public class MindGame : SkillUpgrade<ForceBolt>
{
    public MindGame()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_arcanist__forceBolt_mindgame";
}
