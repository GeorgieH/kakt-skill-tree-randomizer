namespace Kakt.Modding.Core.Skills.FireBolt.Upgrades;

public class Mindgame : SkillUpgrade<FireBolt>
{
    public Mindgame()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Merlin__fireBolt_mindgame";
}
