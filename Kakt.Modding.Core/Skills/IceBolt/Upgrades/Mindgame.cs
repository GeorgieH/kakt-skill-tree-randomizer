namespace Kakt.Modding.Core.Skills.IceBolt.Upgrades;

public class Mindgame : SkillUpgrade<IceBolt>
{
    public Mindgame()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Morgana__iceBolt_mindgame";
}
