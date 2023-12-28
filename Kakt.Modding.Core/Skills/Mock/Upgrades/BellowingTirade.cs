namespace Kakt.Modding.Core.Skills.Mock.Upgrades;

public class BellowingTirade : SkillUpgrade<Mock>
{
    public BellowingTirade()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "RedKnight__mock_bellowingTirade";
}
