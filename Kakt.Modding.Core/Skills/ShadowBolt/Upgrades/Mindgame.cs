namespace Kakt.Modding.Core.Skills.ShadowBolt.Upgrades;

public class Mindgame : SkillUpgrade<ShadowBolt>
{
    public Mindgame()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "SirDagonet__shadowBolt_mindgame";
}
