namespace Kakt.Modding.Core.Skills.Mock.Upgrades;

public class MasterfulInsults : SkillUpgrade<Mock>
{
    public MasterfulInsults()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "RedKnight__mock_masterfulInsults";
}
