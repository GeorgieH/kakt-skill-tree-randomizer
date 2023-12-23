namespace Kakt.Modding.Core.Skills.FlamingStrike.Upgrades;

public class UndeadBane : SkillUpgrade<FlamingStrike>
{
    public UndeadBane()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirPercivale__flamingStrike_undeadbane";
}
