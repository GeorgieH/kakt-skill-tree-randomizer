namespace Kakt.Modding.Core.Skills.BleedingStrike.Upgrades;

public class DeeperCuts : SkillUpgrade<BleedingStrike>
{
    public DeeperCuts()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "RedKnight__bleedingStrike_deeperCuts";
}
